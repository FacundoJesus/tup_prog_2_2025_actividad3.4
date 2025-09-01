namespace Ejercicio1
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
            groupBox1 = new GroupBox();
            btnCrearFigura = new Button();
            label4 = new Label();
            tbAltoCilindro = new TextBox();
            label5 = new Label();
            tbRadio = new TextBox();
            label3 = new Label();
            tbLargo = new TextBox();
            label2 = new Label();
            tbAltoOrto = new TextBox();
            label1 = new Label();
            tbAncho = new TextBox();
            rbCilindro = new RadioButton();
            rbOrtoedro = new RadioButton();
            lsbResultado = new ListBox();
            btnActualizarListado = new Button();
            btnOrdenarAreas = new Button();
            btnMostrarDatos = new Button();
            lbInfo = new Label();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearFigura);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbAltoCilindro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbLargo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbAltoOrto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(rbCilindro);
            groupBox1.Controls.Add(rbOrtoedro);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Creando una figura";
            // 
            // btnCrearFigura
            // 
            btnCrearFigura.Location = new Point(674, 33);
            btnCrearFigura.Name = "btnCrearFigura";
            btnCrearFigura.Size = new Size(75, 73);
            btnCrearFigura.TabIndex = 13;
            btnCrearFigura.Text = "Crear Figura";
            btnCrearFigura.UseVisualStyleBackColor = true;
            btnCrearFigura.Click += btnCrearFigura_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 92);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 12;
            label4.Text = "Alto";
            // 
            // tbAltoCilindro
            // 
            tbAltoCilindro.Location = new Point(359, 87);
            tbAltoCilindro.Name = "tbAltoCilindro";
            tbAltoCilindro.Size = new Size(100, 23);
            tbAltoCilindro.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 91);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 10;
            label5.Text = "Radio";
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(196, 88);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(100, 23);
            tbRadio.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 40);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Largo";
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(525, 35);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(100, 23);
            tbLargo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 38);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "Alto";
            // 
            // tbAltoOrto
            // 
            tbAltoOrto.Location = new Point(359, 33);
            tbAltoOrto.Name = "tbAltoOrto";
            tbAltoOrto.Size = new Size(100, 23);
            tbAltoOrto.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 37);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Ancho";
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(196, 34);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 3;
            // 
            // rbCilindro
            // 
            rbCilindro.AutoSize = true;
            rbCilindro.Location = new Point(18, 92);
            rbCilindro.Name = "rbCilindro";
            rbCilindro.Size = new Size(67, 19);
            rbCilindro.TabIndex = 2;
            rbCilindro.TabStop = true;
            rbCilindro.Text = "Cilindro";
            rbCilindro.UseVisualStyleBackColor = true;
            // 
            // rbOrtoedro
            // 
            rbOrtoedro.AutoSize = true;
            rbOrtoedro.Location = new Point(18, 34);
            rbOrtoedro.Name = "rbOrtoedro";
            rbOrtoedro.Size = new Size(73, 19);
            rbOrtoedro.TabIndex = 1;
            rbOrtoedro.TabStop = true;
            rbOrtoedro.Text = "Ortoedro";
            rbOrtoedro.UseVisualStyleBackColor = true;
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 171);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(459, 259);
            lsbResultado.TabIndex = 1;
            // 
            // btnActualizarListado
            // 
            btnActualizarListado.Location = new Point(493, 171);
            btnActualizarListado.Name = "btnActualizarListado";
            btnActualizarListado.Size = new Size(75, 73);
            btnActualizarListado.TabIndex = 14;
            btnActualizarListado.Text = "Actualizar Listado";
            btnActualizarListado.UseVisualStyleBackColor = true;
            btnActualizarListado.Click += btnActualizarListado_Click;
            // 
            // btnOrdenarAreas
            // 
            btnOrdenarAreas.Location = new Point(493, 357);
            btnOrdenarAreas.Name = "btnOrdenarAreas";
            btnOrdenarAreas.Size = new Size(75, 73);
            btnOrdenarAreas.TabIndex = 15;
            btnOrdenarAreas.Text = "Ordenar por Volumen";
            btnOrdenarAreas.UseVisualStyleBackColor = true;
            btnOrdenarAreas.Click += btnOrdenarAreas_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(493, 262);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(75, 73);
            btnMostrarDatos.TabIndex = 16;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // lbInfo
            // 
            lbInfo.BackColor = Color.CadetBlue;
            lbInfo.Location = new Point(598, 253);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(190, 82);
            lbInfo.TabIndex = 17;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(lbInfo);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnOrdenarAreas);
            Controls.Add(btnActualizarListado);
            Controls.Add(lsbResultado);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbAncho;
        private RadioButton rbCilindro;
        private RadioButton rbOrtoedro;
        private Button btnCrearFigura;
        private Label label4;
        private TextBox tbAltoCilindro;
        private Label label5;
        private TextBox tbRadio;
        private Label label3;
        private TextBox tbLargo;
        private Label label2;
        private TextBox tbAltoOrto;
        private ListBox lsbResultado;
        private Button btnActualizarListado;
        private Button btnOrdenarAreas;
        private Button btnMostrarDatos;
        private Label lbInfo;
        private Button btnSalir;
    }
}
