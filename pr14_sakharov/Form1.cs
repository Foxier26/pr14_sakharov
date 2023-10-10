using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using pr14_sakharov.ModelEF;

namespace pr14_sakharov
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (new Model1().Users.Any(X =>
            X.Login == loginTxtBox.Text && 
            X.Password == passwordTxtBox.Text))
            {
                MessageBox.Show("Пользователь найден");
                return;
            }
            MessageBox.Show("Пользователь прировнялся к нулю, он полный ноль");
            new CaptchForm().ShowDialog();
        }
    }
}
