namespace Juego.PicasYFijas
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
            label1 = new Label();
            btnGenerar = new Button();
            txtValorSistema = new TextBox();
            lblResultado = new Label();
            label2 = new Label();
            label3 = new Label();
            txtValorUsuario = new TextBox();
            btnJugar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Adivina el número";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(25, 57);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(193, 34);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar número";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtValorSistema
            // 
            txtValorSistema.Location = new Point(229, 111);
            txtValorSistema.Name = "txtValorSistema";
            txtValorSistema.Size = new Size(193, 31);
            txtValorSistema.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(25, 256);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 114);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Sistema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 157);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 6;
            label3.Text = "Jugador";
            // 
            // txtValorUsuario
            // 
            txtValorUsuario.Location = new Point(229, 154);
            txtValorUsuario.Name = "txtValorUsuario";
            txtValorUsuario.Size = new Size(193, 31);
            txtValorUsuario.TabIndex = 5;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(25, 207);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(193, 34);
            btnJugar.TabIndex = 7;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(439, 111);
            button1.Name = "button1";
            button1.Size = new Size(29, 34);
            button1.TabIndex = 8;
            button1.Text = "👁️";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnJugar);
            Controls.Add(label3);
            Controls.Add(txtValorUsuario);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(txtValorSistema);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Picas y Fijas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerar;
        private TextBox txtValorSistema;
        private Label lblResultado;
        private Label label2;
        private Label label3;
        private TextBox txtValorUsuario;
        private Button btnJugar;
        private Button button1;
    }
}
