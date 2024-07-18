using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = textBoxUser.Text;
            string pass = textBoxPass.Text;

            
        }

        private void buttonRegisterForm_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
