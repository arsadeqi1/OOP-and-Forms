using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_بررسي_اشيا_فرم_ها
{
    public class MyForm : Form
    {
        public MyForm()
        {
            var btn = new Button();
            btn.Text = "Click Me";
            btn.Click += (s, e) => { this.Close(); };
            this.Controls.Add(btn);
            btn.Top = 20;
            btn.Left = 40;
            this.Text = "Alireza The Programmer!!!";
        }
    }
}
