namespace registroo
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new Panel();
            cerrar2 = new Button();
            entrar = new Button();
            user = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(cerrar2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 36);
            panel1.TabIndex = 0;
            // 
            // cerrar2
            // 
            cerrar2.FlatAppearance.BorderColor = Color.White;
            cerrar2.FlatAppearance.BorderSize = 0;
            cerrar2.FlatAppearance.MouseDownBackColor = Color.White;
            cerrar2.FlatAppearance.MouseOverBackColor = Color.White;
            cerrar2.Image = (Image)resources.GetObject("cerrar2.Image");
            cerrar2.Location = new Point(333, 3);
            cerrar2.Name = "cerrar2";
            cerrar2.Size = new Size(35, 30);
            cerrar2.TabIndex = 1;
            cerrar2.UseVisualStyleBackColor = true;
            cerrar2.Click += cerrar_Click;
            // 
            // entrar
            // 
            entrar.BackColor = Color.Red;
            entrar.FlatAppearance.BorderColor = Color.Blue;
            entrar.FlatAppearance.BorderSize = 0;
            entrar.FlatAppearance.MouseDownBackColor = Color.Blue;
            entrar.FlatAppearance.MouseOverBackColor = Color.Blue;
            entrar.FlatStyle = FlatStyle.Flat;
            entrar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            entrar.Location = new Point(142, 210);
            entrar.Name = "entrar";
            entrar.Size = new Size(128, 44);
            entrar.TabIndex = 6;
            entrar.Text = "Guardar";
            entrar.UseVisualStyleBackColor = false;
            // 
            // user
            // 
            user.BorderStyle = BorderStyle.None;
            user.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(38, 77);
            user.Name = "user";
            user.Size = new Size(304, 21);
            user.TabIndex = 7;
            user.Text = "Usuario";
            user.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(38, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 21);
            textBox1.TabIndex = 8;
            textBox1.Text = "Contraseña";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(378, 266);
            Controls.Add(textBox1);
            Controls.Add(user);
            Controls.Add(entrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            Text = "Registro";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button cerrar2;
        private Button entrar;
        private TextBox user;
        private TextBox textBox1;
    }
}