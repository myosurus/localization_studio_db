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
            "Вид_медиа",
            "Должность",
            "Приоритет",
            "Статус_выполнения",
            "Статус_документации",
            "Статус_оплаты",
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

                dataGridViewTable.DataSource = localizationDataSet.Tables[selectedTable];

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
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void toolContractActive_Click(object sender, EventArgs e)
        {
            try
            {
                DataView activeContractsView = new DataView(localizationDataSet.Контракты)
                {
                    RowFilter = "Статус_выполнения <> 3"
                };
                dataGridViewTable.DataSource = activeContractsView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolContractUnpaid_Click(object sender, EventArgs e)
        {
            try
            {
                DataView unpaidContractsView = new DataView(localizationDataSet.Контракты)
                {
                    RowFilter = "Статус_оплаты <> 3"
                };
                dataGridViewTable.DataSource = unpaidContractsView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolContractEndSoon_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Today;
                DateTime soon = today.AddDays(30);

                DataView endingSoonView = new DataView(localizationDataSet.Контракты)
                {
                    RowFilter = $"Дата_окончания >= #{today:MM/dd/yyyy}# AND Дата_окончания <= #{soon:MM/dd/yyyy}#"
                };
                dataGridViewTable.DataSource = endingSoonView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolContractByClient_Click(object sender, EventArgs e)
        {
            try
            {
                string input = ShowInputDialog("Фильтр по клиенту", "Введите код клиента: ");

                if (int.TryParse(input, out int clientId))
                {
                    DataView byClientView = new DataView(localizationDataSet.Контракты)
                    {
                        RowFilter = $"Код_клиента = {clientId}"
                    };
                    dataGridViewTable.DataSource = byClientView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolContractNonarchived_Click(object sender, EventArgs e)
        {
            try
            {
                DataView nonArchivedView = new DataView(localizationDataSet.Контракты)
                {
                    RowFilter = "Статус_документации <> 5 AND Статус_выполнения = 3"
                };
                dataGridViewTable.DataSource = nonArchivedView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolProjectPriority_Click(object sender, EventArgs e)
        {
            try
            {
                var projectsView = new DataView(localizationDataSet.Проекты)
                {
                    RowFilter = "Приоритет = 1"
                };
                dataGridViewTable.DataSource = projectsView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolProjectOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var projectsView = new DataView(localizationDataSet.Проекты)
                {
                    RowFilter = "Статус_проекта <> 3"
                };
                dataGridViewTable.DataSource = projectsView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolProjectNoFiles_Click(object sender, EventArgs e)
        {
            try
            {
                var projectsView = new DataView(localizationDataSet.Проекты)
                {
                    RowFilter = "Файлы_проекта IS NULL OR Файлы_проекта = ''"
                };
                dataGridViewTable.DataSource = projectsView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolProjectByContract_Click(object sender, EventArgs e)
        {
            try
            {
                string projectId = ShowInputDialog("Фильтр по контракту", "Введите код контракта: ");

                if (!string.IsNullOrWhiteSpace(projectId))
                {
                    DataView view = new DataView(localizationDataSet.Проекты)
                    {
                        RowFilter = $"Код_контракта = {projectId}"
                    };
                    dataGridViewTable.DataSource = view;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTaskPriority_Click(object sender, EventArgs e)
        {
            try
            {
                DataView highPriorityView = new DataView(localizationDataSet.Задачи)
                {
                    RowFilter = "Приоритет = 1"
                };
                dataGridViewTable.DataSource = highPriorityView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTaskIncomplete_Click(object sender, EventArgs e)
        {
            try
            {
                DataView incompleteTasksView = new DataView(localizationDataSet.Задачи)
                {
                    RowFilter = "Статус_задачи <> 3"
                };
                dataGridViewTable.DataSource = incompleteTasksView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTaskNoFiles_Click(object sender, EventArgs e)
        {
            try
            {
                DataView noFilesView = new DataView(localizationDataSet.Задачи)
                {
                    RowFilter = "ISNULL(Файлы_задачи, '') = ''"
                };
                dataGridViewTable.DataSource = noFilesView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTaskByProject_Click(object sender, EventArgs e)
        {
            try
            {
                string input = ShowInputDialog("Фильтр по проекту", "Введите код проекта: ");

                if (int.TryParse(input, out int taskId))
                {
                    DataView view = new DataView(localizationDataSet.Задачи)
                    {
                        RowFilter = $"Код_проекта = {taskId}"
                    };
                    dataGridViewTable.DataSource = view;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolTaskByEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string input = ShowInputDialog("Фильтр по сотруднику", "Введите код сотрудника: ");

                if (int.TryParse(input, out int taskId))
                {
                    DataView view = new DataView(localizationDataSet.Задачи)
                    {
                        RowFilter = $"Исполнитель = {taskId}"
                    };
                    dataGridViewTable.DataSource = view;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolEmployeeJob_Click(object sender, EventArgs e)
        {
            try
            {
                string input = ShowInputDialog("Фильтр по должности", "Введите код должности: ");

                if (int.TryParse(input, out int employeeId))
                {
                    DataView view = new DataView(localizationDataSet.Сотрудники)
                    {
                        RowFilter = $"Должность = {employeeId}"
                    };
                    dataGridViewTable.DataSource = view;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolEmployeeLastName_Click(object sender, EventArgs e)
        {
            try
            {
                string lastName = ShowInputDialog("Фильтр по фамилии", "Введите фамилию: ");

                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    DataView view = new DataView(localizationDataSet.Сотрудники)
                    {
                        RowFilter = $"Фамилия LIKE '%{lastName}%'"
                    };
                    dataGridViewTable.DataSource = view;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolEmployeeBonus_Click(object sender, EventArgs e)
        {
            try
            {
                DataView view = new DataView(localizationDataSet.Сотрудники)
                {
                    RowFilter = "Надбавка > 5000"
                };
                dataGridViewTable.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolEmployeeNoEmail_Click(object sender, EventArgs e)
        {
            try
            {
                DataView view = new DataView(localizationDataSet.Сотрудники)
                {
                    RowFilter = "ISNULL(Email, '') = ''"
                };
                dataGridViewTable.DataSource = view;
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

                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string input = ShowInputDialog("Фильтр по сотруднику", "Введите код сотрудника: ");
                if (!int.TryParse(input, out int empId)) return;

                var query = from team in localizationDataSet.Проектные_роли
                            where team.Код_сотрудника == empId
                            join project in localizationDataSet.Проекты
                            on team.Код_проекта equals project.Код_проекта
                            select project;

                var result = localizationDataSet.Проекты.Clone();
                foreach (var row in query)
                    result.ImportRow(row);

                dataGridViewTable.DataSource = result;
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

                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                dataGridViewTable.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


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

    }

}
