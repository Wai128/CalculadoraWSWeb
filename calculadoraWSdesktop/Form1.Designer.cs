namespace calculadoraWSdesktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Lb_numero = new System.Windows.Forms.Label();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lb_numero);
            this.panel1.Controls.Add(this.lb_resultado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_numero2);
            this.panel1.Controls.Add(this.txt_numero1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 231);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nota: Por favor solo ingresar Numeros";
            // 
            // Lb_numero
            // 
            this.Lb_numero.AutoSize = true;
            this.Lb_numero.Location = new System.Drawing.Point(27, 184);
            this.Lb_numero.Name = "Lb_numero";
            this.Lb_numero.Size = new System.Drawing.Size(11, 13);
            this.Lb_numero.TabIndex = 16;
            this.Lb_numero.Text = "*";
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(222, 96);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(13, 13);
            this.lb_resultado.TabIndex = 14;
            this.lb_resultado.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resultado";
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(224, 57);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_numero2.TabIndex = 12;
            this.txt_numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero2_KeyPress);
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(224, 19);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_numero1.TabIndex = 11;
            this.txt_numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Digite el numero 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite el numero 1:";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_dividir);
            this.panel2.Controls.Add(this.btn_multiplicar);
            this.panel2.Controls.Add(this.btn_restar);
            this.panel2.Controls.Add(this.btn_sumar);
            this.panel2.Location = new System.Drawing.Point(88, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 46);
            this.panel2.TabIndex = 18;
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(221, 13);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(63, 23);
            this.btn_dividir.TabIndex = 24;
            this.btn_dividir.Text = "Dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(152, 13);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(63, 23);
            this.btn_multiplicar.TabIndex = 23;
            this.btn_multiplicar.Text = "Multiplicar";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click_1);
            // 
            // btn_restar
            // 
            this.btn_restar.Location = new System.Drawing.Point(83, 13);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(63, 23);
            this.btn_restar.TabIndex = 22;
            this.btn_restar.Text = "Restar";
            this.btn_restar.UseVisualStyleBackColor = true;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click_1);
            // 
            // btn_sumar
            // 
            this.btn_sumar.Location = new System.Drawing.Point(14, 13);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(63, 23);
            this.btn_sumar.TabIndex = 21;
            this.btn_sumar.Text = "Sumar";
            this.btn_sumar.UseVisualStyleBackColor = true;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(491, 248);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora WS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lb_numero;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn_sumar;

    }
}

