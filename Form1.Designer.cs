﻿
namespace NachoOpera_Main
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sumar = new System.Windows.Forms.Button();
            this.txt_NumeroUno = new System.Windows.Forms.TextBox();
            this.txt_NumeroDos = new System.Windows.Forms.TextBox();
            this.lbl_numeroUno = new System.Windows.Forms.Label();
            this.lbl_NumeroDos = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_ResultadoTexto = new System.Windows.Forms.Label();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.btn_multiplicacion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sumar
            // 
            this.btn_sumar.Location = new System.Drawing.Point(137, 416);
            this.btn_sumar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(164, 78);
            this.btn_sumar.TabIndex = 0;
            this.btn_sumar.Text = "Sumar";
            this.btn_sumar.UseVisualStyleBackColor = true;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click);
            // 
            // txt_NumeroUno
            // 
            this.txt_NumeroUno.Location = new System.Drawing.Point(137, 257);
            this.txt_NumeroUno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NumeroUno.Name = "txt_NumeroUno";
            this.txt_NumeroUno.Size = new System.Drawing.Size(315, 22);
            this.txt_NumeroUno.TabIndex = 1;
            // 
            // txt_NumeroDos
            // 
            this.txt_NumeroDos.Location = new System.Drawing.Point(555, 257);
            this.txt_NumeroDos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NumeroDos.Name = "txt_NumeroDos";
            this.txt_NumeroDos.Size = new System.Drawing.Size(315, 22);
            this.txt_NumeroDos.TabIndex = 2;
            // 
            // lbl_numeroUno
            // 
            this.lbl_numeroUno.AutoSize = true;
            this.lbl_numeroUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroUno.Location = new System.Drawing.Point(201, 202);
            this.lbl_numeroUno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numeroUno.Name = "lbl_numeroUno";
            this.lbl_numeroUno.Size = new System.Drawing.Size(174, 39);
            this.lbl_numeroUno.TabIndex = 3;
            this.lbl_numeroUno.Text = "Numero 1";
            // 
            // lbl_NumeroDos
            // 
            this.lbl_NumeroDos.AutoSize = true;
            this.lbl_NumeroDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroDos.Location = new System.Drawing.Point(619, 202);
            this.lbl_NumeroDos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NumeroDos.Name = "lbl_NumeroDos";
            this.lbl_NumeroDos.Size = new System.Drawing.Size(174, 39);
            this.lbl_NumeroDos.TabIndex = 4;
            this.lbl_NumeroDos.Text = "Numero 2";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(481, 342);
            this.lbl_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 16);
            this.lbl_Resultado.TabIndex = 5;
            // 
            // lbl_ResultadoTexto
            // 
            this.lbl_ResultadoTexto.AutoSize = true;
            this.lbl_ResultadoTexto.Location = new System.Drawing.Point(400, 342);
            this.lbl_ResultadoTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ResultadoTexto.Name = "lbl_ResultadoTexto";
            this.lbl_ResultadoTexto.Size = new System.Drawing.Size(69, 16);
            this.lbl_ResultadoTexto.TabIndex = 6;
            this.lbl_ResultadoTexto.Text = "Resultado";
            // 
            // btn_Resta
            // 
            this.btn_Resta.Location = new System.Drawing.Point(309, 416);
            this.btn_Resta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(164, 78);
            this.btn_Resta.TabIndex = 7;
            this.btn_Resta.Text = "Resta";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.btn_Resta_Click);
            // 
            // btn_multiplicacion
            // 
            this.btn_multiplicacion.Location = new System.Drawing.Point(416, 338);
            this.btn_multiplicacion.Name = "btn_multiplicacion";
            this.btn_multiplicacion.Size = new System.Drawing.Size(123, 63);
            this.btn_multiplicacion.TabIndex = 8;
            this.btn_multiplicacion.Text = "Multiplicación";
            this.btn_multiplicacion.UseVisualStyleBackColor = true;
            this.btn_multiplicacion.Click += new System.EventHandler(this.btn_multiplicacion_Click);
            this.btn_multiplicacion.Location = new System.Drawing.Point(555, 416);
            this.btn_multiplicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_multiplicacion.Name = "btn_multiplicacion";
            this.btn_multiplicacion.Size = new System.Drawing.Size(164, 78);
            this.btn_multiplicacion.TabIndex = 8;
            this.btn_multiplicacion.Text = "Multiplicación";
            this.btn_multiplicacion.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(727, 416);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 78);
            this.button3.TabIndex = 9;
            this.button3.Text = "División";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_multiplicacion);
            this.Controls.Add(this.btn_Resta);
            this.Controls.Add(this.lbl_ResultadoTexto);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_NumeroDos);
            this.Controls.Add(this.lbl_numeroUno);
            this.Controls.Add(this.txt_NumeroDos);
            this.Controls.Add(this.txt_NumeroUno);
            this.Controls.Add(this.btn_sumar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.TextBox txt_NumeroUno;
        private System.Windows.Forms.TextBox txt_NumeroDos;
        private System.Windows.Forms.Label lbl_numeroUno;
        private System.Windows.Forms.Label lbl_NumeroDos;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_ResultadoTexto;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn_multiplicacion;
        private System.Windows.Forms.Button button3;
    }
}

