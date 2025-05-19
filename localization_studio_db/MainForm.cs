using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace localization_studio_db
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TableAdapterHelper.FillAllTables(localizationDataSet);

            dataGridViewTable.DataSource = localizationDataSet.Проекты;

            toolStripTableBox.Items.Clear();
            toolStripTableBox.Items.AddRange(localizationDataSet.Tables.Cast<DataTable>()
                .Select(t => t.TableName).ToArray());
        }

        private void ToolStripTableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = toolStripTableBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTable)) return;

            dataGridViewTable.DataSource = localizationDataSet.Tables[selectedTable];
        }

    }

}
