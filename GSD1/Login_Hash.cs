using System.Data;

namespace GSD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtSenhaLogin.Text;
            string senha = Crypto.sha256encrypt(txtSenhaLogin.Text);

            foreach (DataRow row in LoginsDataSet.Acessos)
            {
                if (row.ItemArray[1].Equals(usuario) && row.ItemArray[2].Equals(senha))
                {
                    txtUserLogin.Text = String.Empty;
                    txtSenhaLogin.Text = String.Empty;
                    MessageBox.Show("Login realizado com sucesso !");
                    break;
                }

                else
                {
                    MessageBox.Show("Usuário/Senha incorretos");
                    break;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AdicionarUsuario(txtUserLogin.Text, txtSenhaLogin.Text);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
