namespace Localization
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainMenuStrip = new MenuStrip();
            tableComboBox = new ToolStripComboBox();
            запросыToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.BackColor = Color.Thistle;
            mainMenuStrip.Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { tableComboBox, запросыToolStripMenuItem, настройкиToolStripMenuItem, оПрограммеToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(784, 31);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // tableComboBox
            // 
            tableComboBox.BackColor = Color.GhostWhite;
            tableComboBox.Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableComboBox.ForeColor = Color.FromArgb(0, 50, 50);
            tableComboBox.Name = "tableComboBox";
            tableComboBox.Size = new Size(138, 27);
            tableComboBox.Text = "Таблица";
            // 
            // запросыToolStripMenuItem
            // 
            запросыToolStripMenuItem.Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            запросыToolStripMenuItem.ForeColor = Color.FromArgb(0, 50, 50);
            запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            запросыToolStripMenuItem.Size = new Size(77, 27);
            запросыToolStripMenuItem.Text = "Запросы";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            настройкиToolStripMenuItem.ForeColor = Color.FromArgb(0, 50, 50);
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(96, 27);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            оПрограммеToolStripMenuItem.Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            оПрограммеToolStripMenuItem.ForeColor = Color.FromArgb(0, 50, 50);
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(109, 27);
            оПрограммеToolStripMenuItem.Text = "О Программе";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(784, 461);
            Controls.Add(mainMenuStrip);
            Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Localization Studio";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem таблицыToolStripMenuItem;
        private ToolStripMenuItem запросыToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripComboBox tableComboBox;
    }
}
