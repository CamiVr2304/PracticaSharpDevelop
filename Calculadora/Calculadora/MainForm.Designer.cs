/*
 * Creado por SharpDevelop.
 * Usuario: jaime
 * Fecha: 26/10/2026
 * Hora: 05:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtDisplay;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnIgual;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn000;
		private System.Windows.Forms.Button btnPunto;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Button btnPotencia;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		
		protected override void Dispose(bool disposing)
{
    if (disposing)
    {
        if (components != null)
        {
            components.Dispose();
        }
    }

    base.Dispose(disposing);
}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnIgual = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn000 = new System.Windows.Forms.Button();
			this.btnPunto = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnModulo = new System.Windows.Forms.Button();
			this.btnPotencia = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDisplay
			// 
			this.txtDisplay.Location = new System.Drawing.Point(31, 22);
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.Size = new System.Drawing.Size(281, 20);
			this.txtDisplay.TabIndex = 0;
			// 
			// btnSuma
			// 
			this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuma.Location = new System.Drawing.Point(252, 72);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(60, 43);
			this.btnSuma.TabIndex = 2;
			this.btnSuma.Text = "+";
			this.btnSuma.UseVisualStyleBackColor = true;
			// 
			// btnResta
			// 
			this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResta.Location = new System.Drawing.Point(250, 121);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(62, 43);
			this.btnResta.TabIndex = 3;
			this.btnResta.Text = "-";
			this.btnResta.UseVisualStyleBackColor = true;
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicar.Location = new System.Drawing.Point(252, 170);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(60, 39);
			this.btnMultiplicar.TabIndex = 4;
			this.btnMultiplicar.Text = "x";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(252, 215);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(60, 39);
			this.btnDividir.TabIndex = 5;
			this.btnDividir.Text = "/";
			this.btnDividir.UseVisualStyleBackColor = true;
			// 
			// btnIgual
			// 
			this.btnIgual.Location = new System.Drawing.Point(91, 260);
			this.btnIgual.Name = "btnIgual";
			this.btnIgual.Size = new System.Drawing.Size(227, 41);
			this.btnIgual.TabIndex = 6;
			this.btnIgual.Text = "=";
			this.btnIgual.UseVisualStyleBackColor = true;
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(12, 72);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(64, 43);
			this.btn1.TabIndex = 7;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(91, 74);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(67, 42);
			this.btn2.TabIndex = 8;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(173, 74);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(63, 42);
			this.btn3.TabIndex = 9;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			// 
			// btn4
			// 
			this.btn4.Location = new System.Drawing.Point(12, 125);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(64, 40);
			this.btn4.TabIndex = 10;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			// 
			// btn5
			// 
			this.btn5.Location = new System.Drawing.Point(91, 125);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(67, 39);
			this.btn5.TabIndex = 11;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			// 
			// btn6
			// 
			this.btn6.Location = new System.Drawing.Point(173, 125);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(63, 39);
			this.btn6.TabIndex = 12;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			// 
			// btn7
			// 
			this.btn7.Location = new System.Drawing.Point(13, 170);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(63, 39);
			this.btn7.TabIndex = 13;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			// 
			// btn8
			// 
			this.btn8.Location = new System.Drawing.Point(91, 171);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(67, 38);
			this.btn8.TabIndex = 14;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			// 
			// btn9
			// 
			this.btn9.Location = new System.Drawing.Point(173, 171);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(63, 38);
			this.btn9.TabIndex = 15;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			// 
			// btn0
			// 
			this.btn0.Location = new System.Drawing.Point(13, 215);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(65, 39);
			this.btn0.TabIndex = 16;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			// 
			// btn000
			// 
			this.btn000.Location = new System.Drawing.Point(91, 216);
			this.btn000.Name = "btn000";
			this.btn000.Size = new System.Drawing.Size(67, 38);
			this.btn000.TabIndex = 17;
			this.btn000.Text = "000";
			this.btn000.UseVisualStyleBackColor = true;
			// 
			// btnPunto
			// 
			this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPunto.Location = new System.Drawing.Point(173, 216);
			this.btnPunto.Name = "btnPunto";
			this.btnPunto.Size = new System.Drawing.Size(63, 38);
			this.btnPunto.TabIndex = 18;
			this.btnPunto.Text = ".";
			this.btnPunto.UseVisualStyleBackColor = true;
			// 
			// btnC
			// 
			this.btnC.Location = new System.Drawing.Point(12, 264);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(66, 37);
			this.btnC.TabIndex = 19;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			// 
			// btnModulo
			// 
			this.btnModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModulo.Location = new System.Drawing.Point(31, 307);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(252, 32);
			this.btnModulo.TabIndex = 20;
			this.btnModulo.Text = "%";
			this.btnModulo.UseVisualStyleBackColor = true;
			// 
			// btnPotencia
			// 
			this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPotencia.Location = new System.Drawing.Point(91, 345);
			this.btnPotencia.Name = "btnPotencia";
			this.btnPotencia.Size = new System.Drawing.Size(120, 44);
			this.btnPotencia.TabIndex = 21;
			this.btnPotencia.Text = "^";
			this.btnPotencia.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 420);
			this.Controls.Add(this.btnPotencia);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnPunto);
			this.Controls.Add(this.btn000);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btnIgual);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.txtDisplay);
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
