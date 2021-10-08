
namespace WinFormsApp12
{
    partial class FrmLectura
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
            this.montoTotal = new System.Windows.Forms.TextBox();
            this.cantRegistros = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoMoneda = new System.Windows.Forms.TextBox();
            this.cuentaBeneficiario = new System.Windows.Forms.TextBox();
            this.rnc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // montoTotal
            // 
            this.montoTotal.Enabled = false;
            this.montoTotal.Location = new System.Drawing.Point(347, 128);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.Size = new System.Drawing.Size(100, 23);
            this.montoTotal.TabIndex = 56;
            // 
            // cantRegistros
            // 
            this.cantRegistros.Enabled = false;
            this.cantRegistros.Location = new System.Drawing.Point(611, 127);
            this.cantRegistros.Name = "cantRegistros";
            this.cantRegistros.Size = new System.Drawing.Size(100, 23);
            this.cantRegistros.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 52;
            this.label15.Text = "Monto Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(473, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 15);
            this.label16.TabIndex = 51;
            this.label16.Text = "Cantidad de registros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(37, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Detalle";
            // 
            // tipoMoneda
            // 
            this.tipoMoneda.Enabled = false;
            this.tipoMoneda.Location = new System.Drawing.Point(347, 95);
            this.tipoMoneda.Name = "tipoMoneda";
            this.tipoMoneda.Size = new System.Drawing.Size(100, 23);
            this.tipoMoneda.TabIndex = 39;
            // 
            // cuentaBeneficiario
            // 
            this.cuentaBeneficiario.Enabled = false;
            this.cuentaBeneficiario.Location = new System.Drawing.Point(110, 128);
            this.cuentaBeneficiario.Name = "cuentaBeneficiario";
            this.cuentaBeneficiario.Size = new System.Drawing.Size(100, 23);
            this.cuentaBeneficiario.TabIndex = 38;
            // 
            // rnc
            // 
            this.rnc.Enabled = false;
            this.rnc.Location = new System.Drawing.Point(110, 95);
            this.rnc.Name = "rnc";
            this.rnc.Size = new System.Drawing.Size(100, 23);
            this.rnc.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fecha Transacción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tipo de moneda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cuenta ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "RNC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Encabezado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Layaout APA - UNAPEC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Leer Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(606, 137);
            this.dataGridView1.TabIndex = 58;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Checked = false;
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(611, 95);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(100, 23);
            this.dtpFechaRegistro.TabIndex = 76;
            // 
            // FrmLectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 353);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.montoTotal);
            this.Controls.Add(this.cantRegistros);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tipoMoneda);
            this.Controls.Add(this.cuentaBeneficiario);
            this.Controls.Add(this.rnc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLectura";
            this.Text = "Lectura Archivo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox montoTotal;
        private System.Windows.Forms.TextBox cantRegistros;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tipoMoneda;
        private System.Windows.Forms.TextBox cuentaBeneficiario;
        private System.Windows.Forms.TextBox rnc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
    }
}