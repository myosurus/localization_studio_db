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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripTableBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
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
            this.mainMenuStrip.Size = new System.Drawing.Size(1000, 38);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // toolStripTableBox
            // 
            this.toolStripTableBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolStripTableBox.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTableBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripTableBox.Name = "toolStripTableBox";
            this.toolStripTableBox.Size = new System.Drawing.Size(121, 32);
            this.toolStripTableBox.Text = "Таблица";
            // 
            // toolStripQueries
            // 
            this.toolStripQueries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripQueries.Name = "toolStripQueries";
            this.toolStripQueries.Size = new System.Drawing.Size(96, 32);
            this.toolStripQueries.Text = "Запросы";
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(119, 32);
            this.toolStripSettings.Text = "Настройки";
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(137, 32);
            this.toolStripAbout.Text = "О Программе";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Localization Studio";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripComboBox toolStripTableBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripQueries;
        private System.Windows.Forms.ToolStripMenuItem toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
    }
}

