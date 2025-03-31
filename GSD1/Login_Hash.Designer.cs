namespace GSD1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUserLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            btnRegistrar = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblSenhaRegistro = new Label();
            lblUsuarioRegistro = new Label();
            lblConfirmarRegistro = new Label();
            txtConfirmarSenha = new TextBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(43, 63);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            lblUsuario.Click += label1_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(43, 119);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            lblSenha.Click += label2_Click;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(176, 55);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(100, 23);
            txtUserLogin.TabIndex = 2;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(176, 111);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(100, 23);
            txtSenhaLogin.TabIndex = 3;
            txtSenhaLogin.TextChanged += txtUsuarioLogin_TextChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(363, 185);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(649, 504);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(lblUsuario);
            tabPage1.Controls.Add(txtSenhaLogin);
            tabPage1.Controls.Add(txtUserLogin);
            tabPage1.Controls.Add(lblSenha);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(641, 476);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(412, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 164);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(191, 215);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(btnRegistrar);
            tabPage2.Controls.Add(txtUsuario);
            tabPage2.Controls.Add(txtSenha);
            tabPage2.Controls.Add(lblSenhaRegistro);
            tabPage2.Controls.Add(lblUsuarioRegistro);
            tabPage2.Controls.Add(lblConfirmarRegistro);
            tabPage2.Controls.Add(txtConfirmarSenha);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(641, 476);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(461, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 161);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(306, 329);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(197, 96);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 9;
            txtUsuario.TextChanged += textBox2_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(197, 135);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 8;
            // 
            // lblSenhaRegistro
            // 
            lblSenhaRegistro.AutoSize = true;
            lblSenhaRegistro.Location = new Point(60, 143);
            lblSenhaRegistro.Name = "lblSenhaRegistro";
            lblSenhaRegistro.Size = new Size(39, 15);
            lblSenhaRegistro.TabIndex = 7;
            lblSenhaRegistro.Text = "Senha";
            // 
            // lblUsuarioRegistro
            // 
            lblUsuarioRegistro.AutoSize = true;
            lblUsuarioRegistro.Location = new Point(60, 104);
            lblUsuarioRegistro.Name = "lblUsuarioRegistro";
            lblUsuarioRegistro.Size = new Size(47, 15);
            lblUsuarioRegistro.TabIndex = 6;
            lblUsuarioRegistro.Text = "Usuário";
            // 
            // lblConfirmarRegistro
            // 
            lblConfirmarRegistro.AutoSize = true;
            lblConfirmarRegistro.Location = new Point(60, 180);
            lblConfirmarRegistro.Name = "lblConfirmarRegistro";
            lblConfirmarRegistro.Size = new Size(61, 15);
            lblConfirmarRegistro.TabIndex = 4;
            lblConfirmarRegistro.Text = "Confirmar";
            lblConfirmarRegistro.Click += label1_Click_1;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(197, 172);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(100, 23);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(641, 476);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Banco de Dados";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(641, 476);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Configuração";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 756);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUserLogin;
        private TextBox txtSenhaLogin;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label lblConfirmarRegistro;
        private TextBox txtConfirmarSenha;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Label lblSenhaRegistro;
        private Label lblUsuarioRegistro;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private PictureBox pictureBox2;
        private Button btnRegistrar;
    }
}
