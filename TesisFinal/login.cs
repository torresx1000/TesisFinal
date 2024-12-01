using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesisFinal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginb_Click(object sender, EventArgs e)
        {
            if(passs.Text == "1234" && contr.text == "admin")
            {
                Principal prin = new  Principal();
                prin.ShowDialog();
               passs.Text = "";
               contr.text = "";
            }
            else
            {
                MessageBox.Show("Datos incorrectos","MENSAJE");
                passs.Text = "";
                contr.text = "";
            }
        }
    }
}
