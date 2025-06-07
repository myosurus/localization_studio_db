using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace localization_studio_db
{
    public partial class AboutForm : Form
    {
        private readonly HashSet<string> adminOnlyTables = new HashSet<string>
        {
            "Должность",
            "Приоритет",
            "Статус_выполнения",
            "Уровень_языка",
            "Языки"
        };
        private readonly string aboutText;

        public AboutForm()
        {
            InitializeComponent();
            aboutText = "Для простмотра таблицы необходимо выбрать её из списка таблиц." +
                                //"\n\nВНИМАНИЕ: несохраненные изменения будут сброшены при переключении таблицы." +
                                "\nРедактирование некоторых таблиц доступно только в режиме администратора." +
                                $"\nСписок этих таблиц : {string.Join(", ", adminOnlyTables)}." +
                                "\n\nПереход в режим администратора доступен в меню Настройки." +
                                "\n\nДля Выполнения запроса необходимо выбрать его из меню Запросы." +
                                "\n\n1ПИб-02-3оп-22\nБыстрова П.С.";
            labelAbout.Text = aboutText;
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("localization_studio_db.Database.logo.ico"))
            {
                this.Icon = new Icon(stream);
            }
        }
    }
}
