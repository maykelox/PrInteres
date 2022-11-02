namespace PrInteres
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
            this.Interes = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCapital = new System.Windows.Forms.TextBox();
            this.textRazon = new System.Windows.Forms.TextBox();
            this.textTiempo = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texttotalinteres = new System.Windows.Forms.TextBox();
            this.textmontofinal = new System.Windows.Forms.TextBox();
            this.Interes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Interes
            // 
            this.Interes.Controls.Add(this.btnNuevo);
            this.Interes.Controls.Add(this.btncalcular);
            this.Interes.Controls.Add(this.textTiempo);
            this.Interes.Controls.Add(this.textRazon);
            this.Interes.Controls.Add(this.textCapital);
            this.Interes.Controls.Add(this.label3);
            this.Interes.Controls.Add(this.label2);
            this.Interes.Controls.Add(this.label1);
            this.Interes.Location = new System.Drawing.Point(12, 41);
            this.Interes.Name = "Interes";
            this.Interes.Size = new System.Drawing.Size(582, 181);
            this.Interes.TabIndex = 0;
            this.Interes.TabStop = false;
            this.Interes.Text = "Interes";
            this.Interes.Enter += new System.EventHandler(this.Interes_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textmontofinal);
            this.groupBox2.Controls.Add(this.texttotalinteres);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo:";
            // 
            // textCapital
            // 
            this.textCapital.Location = new System.Drawing.Point(73, 45);
            this.textCapital.Name = "textCapital";
            this.textCapital.Size = new System.Drawing.Size(100, 23);
            this.textCapital.TabIndex = 3;
            this.textCapital.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textRazon
            // 
            this.textRazon.Location = new System.Drawing.Point(73, 74);
            this.textRazon.Name = "textRazon";
            this.textRazon.Size = new System.Drawing.Size(100, 23);
            this.textRazon.TabIndex = 4;
            // 
            // textTiempo
            // 
            this.textTiempo.Location = new System.Drawing.Point(73, 104);
            this.textTiempo.Name = "textTiempo";
            this.textTiempo.Size = new System.Drawing.Size(100, 23);
            this.textTiempo.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(219, 45);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(219, 108);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Interes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Monto Final:";
            // 
            // texttotalinteres
            // 
            this.texttotalinteres.Location = new System.Drawing.Point(113, 34);
            this.texttotalinteres.Name = "texttotalinteres";
            this.texttotalinteres.Size = new System.Drawing.Size(100, 23);
            this.texttotalinteres.TabIndex = 2;
            // 
            // textmontofinal
            // 
            this.textmontofinal.Location = new System.Drawing.Point(113, 89);
            this.textmontofinal.Name = "textmontofinal";
            this.textmontofinal.Size = new System.Drawing.Size(100, 23);
            this.textmontofinal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(606, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Interes);
            this.Name = "Form1";
            this.Text = ".:. Estructuras Secuenciales.:.";
            this.Interes.ResumeLayout(false);
            this.Interes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Interes;
        private GroupBox groupBox2;
        private TextBox textTiempo;
        private TextBox textRazon;
        private TextBox textCapital;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNuevo;
        private Button btncalcular;
        private TextBox textmontofinal;
        private TextBox texttotalinteres;
        private Label label5;
        private Label label4;
    }
}