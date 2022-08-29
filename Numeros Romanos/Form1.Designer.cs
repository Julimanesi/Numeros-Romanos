namespace Numeros_Romanos
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.palabra_sal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumRomano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Num_sal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).BeginInit();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(246, 40);
            this.numero.Margin = new System.Windows.Forms.Padding(2);
            this.numero.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(106, 30);
            this.numero.TabIndex = 0;
            this.numero.ValueChanged += new System.EventHandler(this.ingreso);
            this.numero.Enter += new System.EventHandler(this.answer_Enter);
            this.numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ingreso);
            this.numero.Validated += new System.EventHandler(this.ingreso);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "El numero en romano es :";
            // 
            // palabra_sal
            // 
            this.palabra_sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palabra_sal.Location = new System.Drawing.Point(289, 83);
            this.palabra_sal.Margin = new System.Windows.Forms.Padding(0);
            this.palabra_sal.Name = "palabra_sal";
            this.palabra_sal.Size = new System.Drawing.Size(227, 34);
            this.palabra_sal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese un número";
            // 
            // NumRomano
            // 
            this.NumRomano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumRomano.Location = new System.Drawing.Point(316, 119);
            this.NumRomano.Margin = new System.Windows.Forms.Padding(2);
            this.NumRomano.Name = "NumRomano";
            this.NumRomano.Size = new System.Drawing.Size(166, 30);
            this.NumRomano.TabIndex = 5;
            this.NumRomano.TextChanged += new System.EventHandler(this.IngresoRomano);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese un número romano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "El numero en decimal es :";
            // 
            // Num_sal
            // 
            this.Num_sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_sal.Location = new System.Drawing.Point(289, 163);
            this.Num_sal.Margin = new System.Windows.Forms.Padding(0);
            this.Num_sal.Name = "Num_sal";
            this.Num_sal.Size = new System.Drawing.Size(227, 38);
            this.Num_sal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 200);
            this.Controls.Add(this.Num_sal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumRomano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.palabra_sal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Conversor decimal---->romano, Romano--->decimal                         Autor: Ju" +
    "lián Manesi";
            this.Validated += new System.EventHandler(this.ingreso);
            ((System.ComponentModel.ISupportInitialize)(this.numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label palabra_sal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumRomano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Num_sal;
    }
}

