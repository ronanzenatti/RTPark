using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTPark.Entidades;
using RTPark.DAO;

namespace RTPark
{
    public partial class Login : Form
    {
        TelaPrincipal telaPrincipal;
        Funcionarios obj;

        public Login(Form tela)
        {
            InitializeComponent();
            telaPrincipal = (TelaPrincipal)tela;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void Login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);                    
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            String user = txtUsuario.Text;
            String senha = txtSenha.Text;
            senha = Encode64.Base64Encode(Encode64.Base64Encode(senha));

            obj = fDAO.Login(user, senha);
            if (obj != null)
            {
                telaPrincipal.SetUsr(obj);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha Inválidos!!!", "RTPark", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (obj == null)
            {
                obj = new Funcionarios();
                telaPrincipal.SetUsr(obj);
                telaPrincipal.Close();
            }
        }
    }
}
