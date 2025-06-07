using System.Drawing;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripTableBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.контрактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolContractActive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolContractUnpaid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolContractEndSoon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolContractByClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolContractNonarchived = new System.Windows.Forms.ToolStripMenuItem();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProjectPriority = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProjectOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProjectNoFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProjectByContract = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTaskPriority = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTaskIncomplete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTaskNoFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTaskByProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTaskByEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEmployeeJob = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEmployeeLastName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEmployeeBonus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEmployeeNoEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEmployeeC2 = new System.Windows.Forms.ToolStripMenuItem();
            this.другоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOMediaLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOPairs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProjectStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSOPayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOFreeEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.режимАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.localizationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localizationDataSet = new localization_studio_db.LocalizationDataSet();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSet)).BeginInit();
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
            this.mainMenuStrip.Size = new System.Drawing.Size(1050, 38);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // toolStripTableBox
            // 
            this.toolStripTableBox.BackColor = System.Drawing.Color.MintCream;
            this.toolStripTableBox.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTableBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripTableBox.Name = "toolStripTableBox";
            this.toolStripTableBox.Size = new System.Drawing.Size(170, 32);
            this.toolStripTableBox.Text = "Таблица";
            this.toolStripTableBox.SelectedIndexChanged += new System.EventHandler(this.ToolStripTableBox_SelectedIndexChanged);
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
            this.toolStripQueries.Size = new System.Drawing.Size(96, 32);
            this.toolStripQueries.Text = "Запросы";
            // 
            // контрактыToolStripMenuItem
            // 
            this.контрактыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolContractActive,
            this.toolContractUnpaid,
            this.toolContractEndSoon,
            this.toolContractByClient,
            this.toolContractNonarchived});
            this.контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            this.контрактыToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.контрактыToolStripMenuItem.Text = "Контракты";
            // 
            // toolContractActive
            // 
            this.toolContractActive.Name = "toolContractActive";
            this.toolContractActive.Size = new System.Drawing.Size(375, 28);
            this.toolContractActive.Text = "Активные";
            this.toolContractActive.Click += new System.EventHandler(this.toolContractActive_Click);
            // 
            // toolContractUnpaid
            // 
            this.toolContractUnpaid.Name = "toolContractUnpaid";
            this.toolContractUnpaid.Size = new System.Drawing.Size(375, 28);
            this.toolContractUnpaid.Text = "Завершены и не оплачены";
            this.toolContractUnpaid.Click += new System.EventHandler(this.toolContractUnpaid_Click);
            // 
            // toolContractEndSoon
            // 
            this.toolContractEndSoon.Name = "toolContractEndSoon";
            this.toolContractEndSoon.Size = new System.Drawing.Size(375, 28);
            this.toolContractEndSoon.Text = "<=30 дней до конца";
            this.toolContractEndSoon.Click += new System.EventHandler(this.toolContractEndSoon_Click);
            // 
            // toolContractByClient
            // 
            this.toolContractByClient.Name = "toolContractByClient";
            this.toolContractByClient.Size = new System.Drawing.Size(375, 28);
            this.toolContractByClient.Text = "По клиенту";
            this.toolContractByClient.Click += new System.EventHandler(this.toolContractByClient_Click);
            // 
            // toolContractNonarchived
            // 
            this.toolContractNonarchived.Name = "toolContractNonarchived";
            this.toolContractNonarchived.Size = new System.Drawing.Size(375, 28);
            this.toolContractNonarchived.Text = "Завершены и не переданы в архив";
            this.toolContractNonarchived.Click += new System.EventHandler(this.toolContractNonarchived_Click);
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProjectPriority,
            this.toolProjectOpen,
            this.toolProjectNoFiles,
            this.toolProjectByContract});
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.проектыToolStripMenuItem.Text = "Проекты";
            // 
            // toolProjectPriority
            // 
            this.toolProjectPriority.Name = "toolProjectPriority";
            this.toolProjectPriority.Size = new System.Drawing.Size(266, 28);
            this.toolProjectPriority.Text = "Высокий приоритет";
            this.toolProjectPriority.Click += new System.EventHandler(this.toolProjectPriority_Click);
            // 
            // toolProjectOpen
            // 
            this.toolProjectOpen.Name = "toolProjectOpen";
            this.toolProjectOpen.Size = new System.Drawing.Size(266, 28);
            this.toolProjectOpen.Text = "Незавершенные";
            this.toolProjectOpen.Click += new System.EventHandler(this.toolProjectOpen_Click);
            // 
            // toolProjectNoFiles
            // 
            this.toolProjectNoFiles.Name = "toolProjectNoFiles";
            this.toolProjectNoFiles.Size = new System.Drawing.Size(266, 28);
            this.toolProjectNoFiles.Text = "Нет файлов";
            this.toolProjectNoFiles.Click += new System.EventHandler(this.toolProjectNoFiles_Click);
            // 
            // toolProjectByContract
            // 
            this.toolProjectByContract.Name = "toolProjectByContract";
            this.toolProjectByContract.Size = new System.Drawing.Size(266, 28);
            this.toolProjectByContract.Text = "По контракту";
            this.toolProjectByContract.Click += new System.EventHandler(this.toolProjectByContract_Click);
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTaskPriority,
            this.toolTaskIncomplete,
            this.toolTaskNoFiles,
            this.toolTaskByProject,
            this.toolTaskByEmployee});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // toolTaskPriority
            // 
            this.toolTaskPriority.Name = "toolTaskPriority";
            this.toolTaskPriority.Size = new System.Drawing.Size(266, 28);
            this.toolTaskPriority.Text = "Высокий приоритет";
            this.toolTaskPriority.Click += new System.EventHandler(this.toolTaskPriority_Click);
            // 
            // toolTaskIncomplete
            // 
            this.toolTaskIncomplete.Name = "toolTaskIncomplete";
            this.toolTaskIncomplete.Size = new System.Drawing.Size(266, 28);
            this.toolTaskIncomplete.Text = "Незавершенные";
            this.toolTaskIncomplete.Click += new System.EventHandler(this.toolTaskIncomplete_Click);
            // 
            // toolTaskNoFiles
            // 
            this.toolTaskNoFiles.Name = "toolTaskNoFiles";
            this.toolTaskNoFiles.Size = new System.Drawing.Size(266, 28);
            this.toolTaskNoFiles.Text = "Нет файлов";
            this.toolTaskNoFiles.Click += new System.EventHandler(this.toolTaskNoFiles_Click);
            // 
            // toolTaskByProject
            // 
            this.toolTaskByProject.Name = "toolTaskByProject";
            this.toolTaskByProject.Size = new System.Drawing.Size(266, 28);
            this.toolTaskByProject.Text = "По проекту";
            this.toolTaskByProject.Click += new System.EventHandler(this.toolTaskByProject_Click);
            // 
            // toolTaskByEmployee
            // 
            this.toolTaskByEmployee.Name = "toolTaskByEmployee";
            this.toolTaskByEmployee.Size = new System.Drawing.Size(266, 28);
            this.toolTaskByEmployee.Text = "По исполнителю";
            this.toolTaskByEmployee.Click += new System.EventHandler(this.toolTaskByEmployee_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEmployeeJob,
            this.toolEmployeeLastName,
            this.toolEmployeeBonus,
            this.toolEmployeeNoEmail,
            this.toolEmployeeC2});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // toolEmployeeJob
            // 
            this.toolEmployeeJob.Name = "toolEmployeeJob";
            this.toolEmployeeJob.Size = new System.Drawing.Size(226, 28);
            this.toolEmployeeJob.Text = "По должности";
            this.toolEmployeeJob.Click += new System.EventHandler(this.toolEmployeeJob_Click);
            // 
            // toolEmployeeLastName
            // 
            this.toolEmployeeLastName.Name = "toolEmployeeLastName";
            this.toolEmployeeLastName.Size = new System.Drawing.Size(226, 28);
            this.toolEmployeeLastName.Text = "По фамилии";
            this.toolEmployeeLastName.Click += new System.EventHandler(this.toolEmployeeLastName_Click);
            // 
            // toolEmployeeBonus
            // 
            this.toolEmployeeBonus.Name = "toolEmployeeBonus";
            this.toolEmployeeBonus.Size = new System.Drawing.Size(226, 28);
            this.toolEmployeeBonus.Text = "Надбавка > 5000";
            this.toolEmployeeBonus.Click += new System.EventHandler(this.toolEmployeeBonus_Click);
            // 
            // toolEmployeeNoEmail
            // 
            this.toolEmployeeNoEmail.Name = "toolEmployeeNoEmail";
            this.toolEmployeeNoEmail.Size = new System.Drawing.Size(226, 28);
            this.toolEmployeeNoEmail.Text = "Нет email";
            this.toolEmployeeNoEmail.Click += new System.EventHandler(this.toolEmployeeNoEmail_Click);
            // 
            // toolEmployeeC2
            // 
            this.toolEmployeeC2.Name = "toolEmployeeC2";
            this.toolEmployeeC2.Size = new System.Drawing.Size(226, 28);
            this.toolEmployeeC2.Text = "Уровень С2";
            this.toolEmployeeC2.Click += new System.EventHandler(this.toolEmployeeC2_Click);
            // 
            // другоеToolStripMenuItem
            // 
            this.другоеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOLanguages,
            this.toolOMediaLanguage,
            this.toolOPairs,
            this.toolProjectStatus,
            this.toolSOPayout,
            this.toolOTasks,
            this.toolOFreeEmployee});
            this.другоеToolStripMenuItem.Name = "другоеToolStripMenuItem";
            this.другоеToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.другоеToolStripMenuItem.Text = "Другое";
            // 
            // toolOLanguages
            // 
            this.toolOLanguages.Name = "toolOLanguages";
            this.toolOLanguages.Size = new System.Drawing.Size(393, 28);
            this.toolOLanguages.Text = "Владение языками";
            this.toolOLanguages.Click += new System.EventHandler(this.toolOLanguages_Click);
            // 
            // toolOMediaLanguage
            // 
            this.toolOMediaLanguage.Name = "toolOMediaLanguage";
            this.toolOMediaLanguage.Size = new System.Drawing.Size(393, 28);
            this.toolOMediaLanguage.Text = "Медиа по языку";
            this.toolOMediaLanguage.Click += new System.EventHandler(this.toolOMediaLanguage_Click);
            // 
            // toolOPairs
            // 
            this.toolOPairs.Name = "toolOPairs";
            this.toolOPairs.Size = new System.Drawing.Size(393, 28);
            this.toolOPairs.Text = "Языковые пары словарей";
            this.toolOPairs.Click += new System.EventHandler(this.toolOPairs_Click);
            // 
            // toolProjectStatus
            // 
            this.toolProjectStatus.Name = "toolProjectStatus";
            this.toolProjectStatus.Size = new System.Drawing.Size(393, 28);
            this.toolProjectStatus.Text = "Число проектов по статусу";
            this.toolProjectStatus.Click += new System.EventHandler(this.toolProjectStatus_Click);
            // 
            // toolSOPayout
            // 
            this.toolSOPayout.Name = "toolSOPayout";
            this.toolSOPayout.Size = new System.Drawing.Size(393, 28);
            this.toolSOPayout.Text = "Зарплата сотрудников";
            this.toolSOPayout.Click += new System.EventHandler(this.toolSOPayout_Click);
            // 
            // toolOTasks
            // 
            this.toolOTasks.Name = "toolOTasks";
            this.toolOTasks.Size = new System.Drawing.Size(393, 28);
            this.toolOTasks.Text = "Задачи с проектом и исполнителем";
            this.toolOTasks.Click += new System.EventHandler(this.toolOTasks_Click);
            // 
            // toolOFreeEmployee
            // 
            this.toolOFreeEmployee.Name = "toolOFreeEmployee";
            this.toolOFreeEmployee.Size = new System.Drawing.Size(393, 28);
            this.toolOFreeEmployee.Text = "Сотрудники без проекта";
            this.toolOFreeEmployee.Click += new System.EventHandler(this.toolOFreeEmployee_Click);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.режимАдминистратораToolStripMenuItem});
            this.toolStripSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(119, 32);
            this.toolStripSettings.Text = "Настройки";
            // 
            // режимАдминистратораToolStripMenuItem
            // 
            this.режимАдминистратораToolStripMenuItem.CheckOnClick = true;
            this.режимАдминистратораToolStripMenuItem.Name = "режимАдминистратораToolStripMenuItem";
            this.режимАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(301, 28);
            this.режимАдминистратораToolStripMenuItem.Text = "Режим администратора";
            this.режимАдминистратораToolStripMenuItem.CheckedChanged += new System.EventHandler(this.режимАдминистратораToolStripMenuItem_CheckedChanged);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(137, 32);
            this.toolStripAbout.Text = "О Программе";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTable.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewTable.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.Size = new System.Drawing.Size(1030, 452);
            this.dataGridViewTable.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSave.Location = new System.Drawing.Point(844, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 41);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить все";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReset.Location = new System.Drawing.Point(10, 10);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(211, 41);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Сбросить изменения";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1050, 61);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить текущую";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1050, 472);
            this.panel2.TabIndex = 6;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1050, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localization Studio";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem toolContractActive;
        private System.Windows.Forms.ToolStripMenuItem toolContractUnpaid;
        private System.Windows.Forms.ToolStripMenuItem toolContractEndSoon;
        private System.Windows.Forms.ToolStripMenuItem toolContractByClient;
        private System.Windows.Forms.ToolStripMenuItem toolContractNonarchived;
        private System.Windows.Forms.ToolStripMenuItem toolProjectPriority;
        private System.Windows.Forms.ToolStripMenuItem toolProjectOpen;
        private System.Windows.Forms.ToolStripMenuItem toolProjectNoFiles;
        private System.Windows.Forms.ToolStripMenuItem toolProjectByContract;
        private System.Windows.Forms.ToolStripMenuItem toolTaskPriority;
        private System.Windows.Forms.ToolStripMenuItem toolTaskIncomplete;
        private System.Windows.Forms.ToolStripMenuItem toolTaskNoFiles;
        private System.Windows.Forms.ToolStripMenuItem toolTaskByProject;
        private System.Windows.Forms.ToolStripMenuItem toolTaskByEmployee;
        private System.Windows.Forms.ToolStripMenuItem toolEmployeeJob;
        private System.Windows.Forms.ToolStripMenuItem toolEmployeeLastName;
        private System.Windows.Forms.ToolStripMenuItem toolEmployeeBonus;
        private System.Windows.Forms.ToolStripMenuItem toolEmployeeNoEmail;
        private System.Windows.Forms.ToolStripMenuItem toolEmployeeC2;
        private System.Windows.Forms.ToolStripMenuItem toolOLanguages;
        private System.Windows.Forms.ToolStripMenuItem toolOMediaLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolOPairs;
        private System.Windows.Forms.ToolStripMenuItem toolProjectStatus;
        private System.Windows.Forms.ToolStripMenuItem toolSOPayout;
        private System.Windows.Forms.ToolStripMenuItem toolOTasks;
        private System.Windows.Forms.ToolStripMenuItem toolOFreeEmployee;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

