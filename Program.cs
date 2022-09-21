using System.Windows.Forms;

namespace _08_بررسي_اشيا_فرم_ها
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var frm = new MyForm();
            frm.Show();
            frm.FormClosed += (s, e) =>
            {
                MessageBox.Show("You're closing the whole program buddy!!!");
                Application.Exit();
            };

            Application.Run();
        }
    }
}
