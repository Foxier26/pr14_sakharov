using System;
using System.Windows.Forms;

namespace pr14_sakharov.ModelEF
{
    public partial class CaptchForm : Form
    {
        public CaptchForm()
        {
            InitializeComponent();
        }

        private string Captch;

        private void CaptchForm_Load(object sender, EventArgs e)
        {
            CreateCaptch();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            CreateCaptch();
        }

        private void captchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (captchTxtBox.Text == Captch)
                Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CreateCaptch();
        }

        private void CreateCaptch()
        {
            timer1.Stop();

            string combination = "0123456789ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮйцукенгшщзхъфывапролджэячсмитьбю";
            Captch = null;
            Random r = new Random();
            for (int i = 0; i < 5; i++)
                Captch += combination[r.Next(combination.Length)];
            captchLabel.Text = Captch;
            timer1.Start();
        }
    }
}
