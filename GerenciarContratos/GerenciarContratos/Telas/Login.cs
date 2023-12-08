using GerenciarContratos.Aplication.Services;
using GerenciarContratos.Domain.DTO;
using GerenciarContratos.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private readonly ILoginService _loginService;
        public Login(ILoginService loginService)
        {
            _loginService = loginService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var login = await _loginService.Login(textUser.Text, textSenha.Text);

            if(login != null)
            {
                Menu menu = new Menu();

                menu.Show(this);
                
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usúario ou senha invalido!");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
