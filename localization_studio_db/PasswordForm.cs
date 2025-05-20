using System;
using System.Windows.Forms;

namespace localization_studio_db
{
    public partial class PasswordForm : Form
    {
        public string Password => textBoxPassword.Text;

        public PasswordForm()
        {
            InitializeComponent();
        }

    }

}