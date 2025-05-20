namespace localization_studio_db
{
    partial class PasswordForm
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(0, 0);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(336, 24);
            this.textBoxPassword.TabIndex = 0;
            // 
            // buttonPassword
            // 
            this.buttonPassword.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPassword.Location = new System.Drawing.Point(0, 34);
            this.buttonPassword.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(336, 34);
            this.buttonPassword.TabIndex = 1;
            this.buttonPassword.Text = "OK";
            this.buttonPassword.UseVisualStyleBackColor = true;
            // 
            // AdminPasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 68);
            this.Controls.Add(this.buttonPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPasswordPrompt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonPassword;
    }
}