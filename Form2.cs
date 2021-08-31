using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCicinho
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();  //a variavel login vai receber o "new form1" ou seja vai abrir a tela inicial de login FORM1
            this.Hide();
            login.Show();
        }
    }
}
