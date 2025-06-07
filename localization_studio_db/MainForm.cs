using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace localization_studio_db
{
    public partial class MainForm : Form
    {

        private readonly HashSet<string> adminOnlyTables = new HashSet<string>
        {
            "Должность",
            "Приоритет",
            "Статус_выполнения",
            "Уровень_языка",
            "Языки"
        };

        private bool isAdminMode = false;

        public MainForm()
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("localization_studio_db.Database.logo.ico"))
            {
                this.Icon = new Icon(stream);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            localizationDataSet.RejectChanges();
            bool isAdmin = режимАдминистратораToolStripMenuItem.Checked;
            TableAdapterHelper.FillAllTables(localizationDataSet, isAdmin);

            toolStripTableBox.Items.Clear();
            toolStripTableBox.Items.AddRange(localizationDataSet.Tables.Cast<DataTable>()
                .Select(t => t.TableName).ToArray());
        }

        private void ToolStripTableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (toolStripTableBox.SelectedItem == null)
                    return;

                string selectedTable = toolStripTableBox.SelectedItem.ToString();

                if (!localizationDataSet.Tables.Contains(selectedTable))
                {
                    MessageBox.Show($"Таблица '{selectedTable}' не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable table = localizationDataSet.Tables[selectedTable];

                dataGridViewTable.AutoGenerateColumns = false;
                dataGridViewTable.Columns.Clear();

                ReplaceForeignKeysWithComboBoxes(table, selectedTable); 
                dataGridViewTable.DataSource = table;

                bool allowEdit = isAdminMode || !adminOnlyTables.Contains(selectedTable);
                dataGridViewTable.ReadOnly = !allowEdit;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при смене таблицы:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void режимАдминистратораToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (режимАдминистратораToolStripMenuItem.Checked)
            {
                using (var prompt = new PasswordForm())
                {
                    if (prompt.ShowDialog() == DialogResult.OK && prompt.Password == "admin")
                    {
                        isAdminMode = true;
                    }
                    else
                    {
                        MessageBox.Show("Неудачный вход");
                        режимАдминистратораToolStripMenuItem.Checked = false;
                    }
                }
            }
            else isAdminMode = false;

            TableAdapterHelper.ClearAllTables(localizationDataSet);
            TableAdapterHelper.FillAllTables(localizationDataSet, isAdminMode);
            ToolStripTableBox_SelectedIndexChanged(null, null);
        }


        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void ApplyFilter(DataView view, string tableName)
        {
            try
            {
                dataGridViewTable.AutoGenerateColumns = false;
                dataGridViewTable.Columns.Clear();

                ReplaceForeignKeysWithComboBoxes(view.Table, tableName); 
                dataGridViewTable.DataSource = view;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void ApplyFilter(DataTable table, string rowFilter)
        {
            ApplyFilter(new DataView(table) { RowFilter = rowFilter }, table.TableName);
        }

        private void ApplyFilter(Func<DataTable> getTable, string rowFilter)
        {
            var table = getTable();
            ApplyFilter(new DataView(table) { RowFilter = rowFilter }, table.TableName);
        }

        private void ApplyInputFilter(Func<string, string> buildFilter, DataTable table, string promptTitle, string promptText)
        {
            try
            {
                string input = ShowInputDialog(promptTitle, promptText);
                if (!string.IsNullOrWhiteSpace(input))
                {
                    var view = new DataView(table) { RowFilter = buildFilter(input) };
                    ApplyFilter(view, table.TableName);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }


        private void ShowError(Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolContractActive_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Контракты, "Статус_выполнения <> 3");

        private void toolContractUnpaid_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Контракты, "Статус_оплаты <> 'Оплачено'");

        private void toolContractEndSoon_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Today;
                DateTime soon = today.AddDays(30);
                string filter = $"Дата_окончания >= #{today:MM/dd/yyyy}# AND Дата_окончания <= #{soon:MM/dd/yyyy}#";
                dataGridViewTable.DataSource = new DataView(localizationDataSet.Контракты) { RowFilter = filter };
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void toolContractByClient_Click(object sender, EventArgs e) =>
            ApplyInputFilter(input => int.TryParse(input, out int id) ?
            $"Код_клиента = {id}" : "1=0", localizationDataSet.Контракты, "Фильтр по клиенту", "Введите код клиента: ");

        //this
        private void toolContractNonarchived_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Контракты, "Статус_документации <> 'Архив' AND Статус_выполнения = 3");

        private void toolProjectPriority_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Проекты, "Приоритет = 1");

        private void toolProjectOpen_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Проекты, "Статус_проекта <> 3");

        private void toolProjectNoFiles_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Проекты, "Файлы_проекта IS NULL OR Файлы_проекта = ''");

        private void toolProjectByContract_Click(object sender, EventArgs e) =>
            ApplyInputFilter(input => $"Код_контракта = {input}", localizationDataSet.Проекты, "Фильтр по контракту", "Введите код контракта: ");

        private void toolTaskPriority_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Задачи, "Приоритет = 1");

        private void toolTaskIncomplete_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Задачи, "Статус_задачи <> 3");

        private void toolTaskNoFiles_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Задачи, "ISNULL(Файлы_задачи, '') = ''");

        private void toolTaskByProject_Click(object sender, EventArgs e) =>
            ApplyInputFilter(input => int.TryParse(input, out int id)
            ? $"Код_проекта = {id}" : "1=0", localizationDataSet.Задачи, "Фильтр по проекту", "Введите код проекта: ");

        private void toolTaskByEmployee_Click(object sender, EventArgs e) =>
            ApplyInputFilter(input => int.TryParse(input, out int id)
            ? $"Исполнитель = {id}" : "1=0", localizationDataSet.Задачи, "Фильтр по сотруднику", "Введите код сотрудника: ");

        private void toolEmployeeJob_Click(object sender, EventArgs e) =>
            ApplyInputFilter(input => int.TryParse(input, out int id)
            ? $"Должность = {id}" : "1=0", localizationDataSet.Сотрудники, "Фильтр по должности", "Введите код должности: ");

        private void toolEmployeeLastName_Click(object sender, EventArgs e) =>
            ApplyInputFilter(input => $"Фамилия LIKE '%{input}%'", localizationDataSet.Сотрудники, "Фильтр по фамилии", "Введите фамилию: ");

        private void toolEmployeeBonus_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Сотрудники, "Надбавка > 5000");

        private void toolEmployeeNoEmail_Click(object sender, EventArgs e) =>
            ApplyFilter(localizationDataSet.Сотрудники, "ISNULL(Email, '') = ''");


        private string ShowInputDialog(string title, string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = prompt, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 80, DialogResult = DialogResult.OK };

            confirmation.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(inputBox);
            promptForm.Controls.Add(confirmation);
            promptForm.AcceptButton = confirmation;

            return promptForm.ShowDialog() == DialogResult.OK ? inputBox.Text : null;
        }

        private void toolOLanguages_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable();
                result.Columns.Add("ФИО");
                result.Columns.Add("Язык");
                result.Columns.Add("Уровень");

                foreach (var владение in localizationDataSet.Владение_языками)
                {
                    var сотрудник = localizationDataSet.Сотрудники.FindByКод_сотрудника(владение.Код_сотрудника);
                    var язык = localizationDataSet.Языки.FindByКод_языка(владение.Код_языка);

                    if (сотрудник != null && язык != null)
                    {
                        result.Rows.Add(
                            $"{сотрудник.Фамилия} {сотрудник.Имя} {сотрудник.Отчество}",
                            язык.Язык,
                            владение.Код_уровня
                        );
                    }
                }

                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolOProjectEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                //string input = ShowInputDialog("Фильтр по сотруднику", "Введите код сотрудника: ");
                //if (!int.TryParse(input, out int empId)) return;

                //var query = from team in localizationDataSet.Проектные_роли
                //            where team.Код_сотрудника == empId
                //            join project in localizationDataSet.Проекты
                //            on team.Код_проекта equals project.Код_проекта
                //            select project;

                //var result = localizationDataSet.Проекты.Clone();
                //foreach (var row in query)
                //    result.ImportRow(row);

                //dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolOMediaLanguage_Click(object sender, EventArgs e)
        {
            try
            {
                string input = ShowInputDialog("Фильтр по языку", "Введите код языка: ");
                if (!int.TryParse(input, out int langId)) return;

                var query = localizationDataSet.Медиа.AsEnumerable()
                    .Where(row => row.Field<byte>("Язык") == langId);

                var result = localizationDataSet.Медиа.Clone();
                foreach (var row in query)
                    result.ImportRow(row);

                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolOPairs_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable();
                result.Columns.Add("Язык 1");
                result.Columns.Add("Язык 2");
                result.Columns.Add("Ссылка на словарь");

                foreach (var row in localizationDataSet.Словари)
                {
                    var lang1 = localizationDataSet.Языки.FindByКод_языка(row.Язык_оригинала);
                    var lang2 = localizationDataSet.Языки.FindByКод_языка(row.Язык_перевода);

                    if (lang1 != null && lang2 != null)
                    {
                        result.Rows.Add(lang1.Язык, lang2.Язык, row.Ссылка_на_словарь);
                    }
                }

                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolProjectStatus_Click(object sender, EventArgs e)
        {
            try
            {
                var query = localizationDataSet.Проекты.AsEnumerable()
                    .GroupBy(p => p.Field<byte>("Статус_проекта"))
                    .Select(g => new { Статус = g.Key, Количество = g.Count() });

                var result = new DataTable();
                result.Columns.Add("Статус");
                result.Columns.Add("Количество");

                foreach (var row in query)
                    result.Rows.Add(row.Статус, row.Количество);

                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolSOPayout_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable();
                result.Columns.Add("ФИО");
                result.Columns.Add("Должность");
                result.Columns.Add("Оклад", typeof(decimal));
                result.Columns.Add("Надбавка", typeof(decimal));
                result.Columns.Add("Сумма", typeof(decimal));

                foreach (var сотрудник in localizationDataSet.Сотрудники)
                {
                    var должность = localizationDataSet.Должность.FindByКод_должности(сотрудник.Должность);
                    if (должность != null)
                    {
                        decimal оклад = должность.Стандартный_оклад;
                        decimal надбавка = сотрудник.Надбавка;
                        result.Rows.Add(
                            $"{сотрудник.Фамилия} {сотрудник.Имя} {сотрудник.Отчество}",
                            должность.Название_должности,
                            оклад,
                            надбавка,
                            оклад + надбавка
                        );
                    }
                }
                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolProjectAudio_Click(object sender, EventArgs e)
        {
            try
            {
                var projectsTable = localizationDataSet.Проекты;
                var mediaTable = localizationDataSet.Медиа;

                var query = from project in projectsTable.AsEnumerable()
                            join media in mediaTable.AsEnumerable()
                            on project.Field<int>("Код_медиа") equals media.Field<int>("Код_медиа")
                            where media.Field<byte>("Вид") == 2
                            select project;

                DataTable result = projectsTable.Clone();

                foreach (var proj in query)
                    result.ImportRow(proj);

                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolEmployeeC2_Click(object sender, EventArgs e)
        {
            try
            {
                var владения = localizationDataSet.Владение_языками;
                var сотрудники = localizationDataSet.Сотрудники;
                var языки = localizationDataSet.Языки;

                DataTable result = new DataTable();
                result.Columns.Add("ФИО");
                result.Columns.Add("Язык");
                result.Columns.Add("Уровень");

                foreach (var владение in владения)
                {
                    if (владение.Код_уровня == "C2")
                    {
                        var сотрудник = сотрудники.FindByКод_сотрудника(владение.Код_сотрудника);
                        var язык = языки.FindByКод_языка(владение.Код_языка);

                        if (сотрудник != null && язык != null)
                        {
                            result.Rows.Add(
                                $"{сотрудник.Фамилия} {сотрудник.Имя} {сотрудник.Отчество}",
                                язык.Язык,
                                владение.Код_уровня
                            );
                        }
                    }
                }

                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void toolOTasks_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable();
                result.Columns.Add("Код задачи");
                result.Columns.Add("Проект");
                result.Columns.Add("Исполнитель");

                foreach (var task in localizationDataSet.Задачи)
                {
                    var project = localizationDataSet.Проекты.FindByКод_проекта(task.Код_проекта);
                    var emp = localizationDataSet.Сотрудники.FindByКод_сотрудника(task.Исполнитель);

                    result.Rows.Add(task.Код_задачи,
                        project != null ? project.Код_проекта.ToString() : "—",
                        emp != null ? $"{emp.Фамилия} {emp.Имя}" : "—");
                }
                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolOFreeEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var engagedIds = localizationDataSet.Проектные_роли
                    .Select(row => row.Код_сотрудника)
                    .Distinct()
                    .ToHashSet();

                var result = localizationDataSet.Сотрудники.Clone();

                foreach (var сотрудник in localizationDataSet.Сотрудники)
                {
                    if (!engagedIds.Contains(сотрудник.Код_сотрудника))
                        result.ImportRow(сотрудник);
                }
                dataGridViewTable.AutoGenerateColumns = true;
                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewTable.EndEdit();
                this.Validate();
                TableAdapterHelper.UpdateAllTables(localizationDataSet);

                MessageBox.Show("Изменения сохранены успешно!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                localizationDataSet.RejectChanges();
                MessageBox.Show("Изменения сброшены.", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сбросе: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaceForeignKeysWithComboBoxes(DataTable table, string tableName)
        {
            var grid = dataGridViewTable;

            // Map of foreign key columns: [TableName, ColumnName] => (LookupTable, ValueMember, DisplayMember)
            var fkMappings = new Dictionary<(string Table, string Column), (DataTable Lookup, string ValueMember, string DisplayMember)>
            {
                // Задачи
                { ("Задачи", "Исполнитель"), (localizationDataSet.Сотрудники, "Код_сотрудника", "Фамилия") },
                { ("Задачи", "Приоритет"), (localizationDataSet.Приоритет, "Код_приоритета", "Приоритет") },
                { ("Задачи", "Статус_задачи"), (localizationDataSet.Статус_выполнения, "Код", "Статус_выполнения") },
                { ("Задачи", "Код_проекта"), (localizationDataSet.Проекты, "Код_проекта", "Код_проекта") },

                // Владение_языками
                { ("Владение_языками", "Код_сотрудника"), (localizationDataSet.Сотрудники, "Код_сотрудника", "Фамилия") },
                { ("Владение_языками", "Код_языка"), (localizationDataSet.Языки, "Код_языка", "Язык") },
                { ("Владение_языками", "Код_уровня"), (localizationDataSet.Уровень_языка, "Код_уровня", "Название_уровня") },

                // Проекты
                { ("Проекты", "Код_контракта"), (localizationDataSet.Контракты, "Код_контракта", "Код_контракта") },
                { ("Проекты", "Код_медиа"), (localizationDataSet.Медиа, "Код_медиа", "Название") },
                { ("Проекты", "Статус_проекта"), (localizationDataSet.Статус_выполнения, "Код", "Статус_выполнения") },
                { ("Проекты", "Приоритет"), (localizationDataSet.Приоритет, "Код_приоритета", "Приоритет") },

                // Сотрудники
                { ("Сотрудники", "Должность"), (localizationDataSet.Должность, "Код_должности", "Название_должности") },

                // Контракты
                { ("Контракты", "Код_клиента"), (localizationDataSet.Клиенты, "Код_клиента", "Фамилия") },
                { ("Контракты", "Статус_выполнения"), (localizationDataSet.Статус_выполнения, "Код", "Статус_выполнения") },

                // Медиа
                { ("Медиа", "Язык"), (localizationDataSet.Языки, "Код_языка", "Язык") },

                // Проектные роли
                { ("Проектные_роли", "Код_сотрудника"), (localizationDataSet.Сотрудники, "Код_сотрудника", "Фамилия")},

                // Словари
                { ("Словари", "Язык_оригинала"), (localizationDataSet.Языки, "Код_языка", "Язык") },
                { ("Словари", "Язык_перевода"), (localizationDataSet.Языки, "Код_языка", "Язык") }
            };

            foreach (DataColumn column in table.Columns)
            {
                var key = (tableName, column.ColumnName);
                if (fkMappings.TryGetValue(key, out var lookup))
                {
                    grid.Columns.Add(new DataGridViewComboBoxColumn
                    {
                        DataPropertyName = column.ColumnName,
                        HeaderText = column.Caption ?? column.ColumnName,
                        DataSource = lookup.Lookup,
                        ValueMember = lookup.ValueMember,
                        DisplayMember = lookup.DisplayMember,
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                    });
                }
                else
                {
                    grid.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = column.ColumnName,
                        HeaderText = column.Caption ?? column.ColumnName
                    });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewTable.EndEdit();
                this.Validate();

                string selectedTable = toolStripTableBox.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedTable))
                {
                    MessageBox.Show("Выберите таблицу для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = TableAdapterHelper.UpdateSingleTable(selectedTable, localizationDataSet);

                if (success)
                {
                    MessageBox.Show("Изменения сохранены успешно!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить изменения. Таблица не поддерживается или произошла ошибка.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
