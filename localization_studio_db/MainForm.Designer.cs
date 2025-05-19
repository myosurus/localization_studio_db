namespace localization_studio_db
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripTableBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.контрактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.режимАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.localizationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localizationDataSet = new localization_studio_db.LocalizationDataSet();
            this.localizationDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Thistle;
            this.mainMenuStrip.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTableBox,
            this.toolStripQueries,
            this.toolStripSettings,
            this.toolStripAbout});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.mainMenuStrip.Size = new System.Drawing.Size(825, 33);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // toolStripTableBox
            // 
            this.toolStripTableBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolStripTableBox.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTableBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripTableBox.Name = "toolStripTableBox";
            this.toolStripTableBox.Size = new System.Drawing.Size(150, 27);
            this.toolStripTableBox.Text = "Таблица";
            // 
            // toolStripQueries
            // 
            this.toolStripQueries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрактыToolStripMenuItem,
            this.проектыToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.другоеToolStripMenuItem});
            this.toolStripQueries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripQueries.Name = "toolStripQueries";
            this.toolStripQueries.Size = new System.Drawing.Size(77, 27);
            this.toolStripQueries.Text = "Запросы";
            // 
            // контрактыToolStripMenuItem
            // 
            this.контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            this.контрактыToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.контрактыToolStripMenuItem.Text = "Контракты";
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.проектыToolStripMenuItem.Text = "Проекты";
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // другоеToolStripMenuItem
            // 
            this.другоеToolStripMenuItem.Name = "другоеToolStripMenuItem";
            this.другоеToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.другоеToolStripMenuItem.Text = "Другое";
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимАдминистратораToolStripMenuItem});
            this.toolStripSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(96, 27);
            this.toolStripSettings.Text = "Настройки";
            // 
            // режимАдминистратораToolStripMenuItem
            // 
            this.режимАдминистратораToolStripMenuItem.CheckOnClick = true;
            this.режимАдминистратораToolStripMenuItem.Name = "режимАдминистратораToolStripMenuItem";
            this.режимАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.режимАдминистратораToolStripMenuItem.Text = "Режим администратора";
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(109, 27);
            this.toolStripAbout.Text = "О Программе";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AutoGenerateColumns = false;
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.DataSource = this.localizationDataSetBindingSource;
            this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewTable.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewTable.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(825, 438);
            this.dataGridViewTable.TabIndex = 1;
            // 
            // localizationDataSetBindingSource
            // 
            this.localizationDataSetBindingSource.DataSource = this.localizationDataSet;
            this.localizationDataSetBindingSource.Position = 0;
            // 
            // localizationDataSet
            // 
            this.localizationDataSet.DataSetName = "LocalizationDataSet";
            this.localizationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localizationDataSetBindingSource1
            // 
            this.localizationDataSetBindingSource1.DataSource = this.localizationDataSet;
            this.localizationDataSetBindingSource1.Position = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(825, 498);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Localization Studio";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripComboBox toolStripTableBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripQueries;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.ToolStripMenuItem режимАдминистратораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другоеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.BindingSource localizationDataSetBindingSource;
        private LocalizationDataSet localizationDataSet;
        private System.Windows.Forms.BindingSource localizationDataSetBindingSource1;
    }
}

