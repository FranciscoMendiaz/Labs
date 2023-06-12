namespace Academia
{
    partial class formLogin
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
            btnIngresar = new Button();
            txtUsu = new TextBox();
            txtPass = new TextBox();
            lnkOlvidaPass = new LinkLabel();
            label1 = new Label();
            lblUsu = new Label();
            lblPass = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(260, 231);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsu
            // 
            txtUsu.Location = new Point(246, 116);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(100, 23);
            txtUsu.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(246, 165);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 2;
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Location = new Point(27, 308);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(119, 15);
            lnkOlvidaPass.TabIndex = 3;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidé mi contraseña";
            lnkOlvidaPass.LinkClicked += lnkOlvidaPass_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 64);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 4;
            label1.Text = "Bienvenid@ al Sistema\r\nPor favor digite su información de ingreso\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // lblUsu
            // 
            lblUsu.AutoSize = true;
            lblUsu.Location = new Point(142, 119);
            lblUsu.Name = "lblUsu";
            lblUsu.Size = new Size(47, 15);
            lblUsu.TabIndex = 5;
            lblUsu.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(142, 168);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 6;
            lblPass.Text = "Contraseña";
            // 
            // formLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 352);
            Controls.Add(lblPass);
            Controls.Add(lblUsu);
            Controls.Add(label1);
            Controls.Add(lnkOlvidaPass);
            Controls.Add(txtPass);
            Controls.Add(txtUsu);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ingreso";
            Load += Academia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsu;
        private TextBox txtPass;
        private LinkLabel lnkOlvidaPass;
        private Label label1;
        private Label lblUsu;
        private Label lblPass;
    }
}