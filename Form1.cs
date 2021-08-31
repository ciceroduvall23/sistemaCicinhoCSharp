using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaCicinho
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "cicero" && textBox2.Text == "1234")
            {
                this.Close(); //assim que o login e senha estiverem corretos a tela irá fechar
                nt = new Thread(novoForm); //novoForm foi criado como uma nova threading
                nt.SetApartmentState(ApartmentState.STA); // estado que essa Threading vai assumir antes de ser iniciada o estado vai ser singer threading para ser único. 
                nt.Start();  //startar um novo formulário                          
                //multi Threading --> MTA.   Singer Threading STA 
            }
            else
            {
                MessageBox.Show("Seu Login ou Senha deve está incorreta");
            }
        }

        private void novoForm() //uma função que irá abrir uma tela atraves da variavel novoForm
        {
            Application.Run(new Form2());  //vai abrir o Form que é o nome da segunda tela ou seja aplicação vai esta rodando uma nova tela bem vindo  
        }

    }
    }

