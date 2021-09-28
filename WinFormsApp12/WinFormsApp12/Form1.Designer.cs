
namespace WinFormsApp12
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tipoRegistro = new System.Windows.Forms.TextBox();
            this.rnc = new System.Windows.Forms.TextBox();
            this.cuentaBeneficiario = new System.Windows.Forms.TextBox();
            this.tipoMoneda = new System.Windows.Forms.TextBox();
            this.fechaTransaccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tipoRegistroD = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.cuentaEmpleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.montoTotal = new System.Windows.Forms.TextBox();
            this.cantRegistros = new System.Windows.Forms.TextBox();
            this.tipoRegistroS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Layaout APA - UNAPEC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encabezado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "RNC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuenta ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de moneda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Transacción";
            // 
            // tipoRegistro
            // 
            this.tipoRegistro.Location = new System.Drawing.Point(106, 114);
            this.tipoRegistro.Name = "tipoRegistro";
            this.tipoRegistro.Size = new System.Drawing.Size(100, 23);
            this.tipoRegistro.TabIndex = 7;
            // 
            // rnc
            // 
            this.rnc.Location = new System.Drawing.Point(106, 144);
            this.rnc.Name = "rnc";
            this.rnc.Size = new System.Drawing.Size(100, 23);
            this.rnc.TabIndex = 8;
            // 
            // cuentaBeneficiario
            // 
            this.cuentaBeneficiario.Location = new System.Drawing.Point(374, 114);
            this.cuentaBeneficiario.Name = "cuentaBeneficiario";
            this.cuentaBeneficiario.Size = new System.Drawing.Size(100, 23);
            this.cuentaBeneficiario.TabIndex = 9;
            // 
            // tipoMoneda
            // 
            this.tipoMoneda.Location = new System.Drawing.Point(374, 143);
            this.tipoMoneda.Name = "tipoMoneda";
            this.tipoMoneda.Size = new System.Drawing.Size(100, 23);
            this.tipoMoneda.TabIndex = 10;
            // 
            // fechaTransaccion
            // 
            this.fechaTransaccion.Location = new System.Drawing.Point(626, 114);
            this.fechaTransaccion.Name = "fechaTransaccion";
            this.fechaTransaccion.Size = new System.Drawing.Size(100, 23);
            this.fechaTransaccion.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Detalle";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Location = new System.Drawing.Point(26, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 15);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Cédula";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Monto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Tipo Registro";
            // 
            // tipoRegistroD
            // 
            this.tipoRegistroD.Location = new System.Drawing.Point(106, 219);
            this.tipoRegistroD.Name = "tipoRegistroD";
            this.tipoRegistroD.Size = new System.Drawing.Size(100, 23);
            this.tipoRegistroD.TabIndex = 17;
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(106, 248);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(100, 23);
            this.cedula.TabIndex = 18;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(374, 219);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(100, 23);
            this.monto.TabIndex = 19;
            // 
            // cuentaEmpleado
            // 
            this.cuentaEmpleado.Location = new System.Drawing.Point(374, 247);
            this.cuentaEmpleado.Name = "cuentaEmpleado";
            this.cuentaEmpleado.Size = new System.Drawing.Size(100, 23);
            this.cuentaEmpleado.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cuenta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sumario";
            // 
            // montoTotal
            // 
            this.montoTotal.Location = new System.Drawing.Point(400, 333);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.Size = new System.Drawing.Size(100, 23);
            this.montoTotal.TabIndex = 28;
            // 
            // cantRegistros
            // 
            this.cantRegistros.Location = new System.Drawing.Point(138, 364);
            this.cantRegistros.Name = "cantRegistros";
            this.cantRegistros.Size = new System.Drawing.Size(100, 23);
            this.cantRegistros.TabIndex = 27;
            // 
            // tipoRegistroS
            // 
            this.tipoRegistroS.Location = new System.Drawing.Point(138, 333);
            this.tipoRegistroS.Name = "tipoRegistroS";
            this.tipoRegistroS.Size = new System.Drawing.Size(100, 23);
            this.tipoRegistroS.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Tipo Registro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(323, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Monto Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "Cantidad de registros";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(638, 412);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 29;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 447);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.montoTotal);
            this.Controls.Add(this.cantRegistros);
            this.Controls.Add(this.tipoRegistroS);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cuentaEmpleado);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.tipoRegistroD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fechaTransaccion);
            this.Controls.Add(this.tipoMoneda);
            this.Controls.Add(this.cuentaBeneficiario);
            this.Controls.Add(this.rnc);
            this.Controls.Add(this.tipoRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tipoRegistro;
        private System.Windows.Forms.TextBox rnc;
        private System.Windows.Forms.TextBox cuentaBeneficiario;
        private System.Windows.Forms.TextBox tipoMoneda;
        private System.Windows.Forms.TextBox fechaTransaccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tipoRegistroD;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.TextBox cuentaEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox montoTotal;
        private System.Windows.Forms.TextBox cantRegistros;
        private System.Windows.Forms.TextBox tipoRegistroS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEnviar;
    }
}

