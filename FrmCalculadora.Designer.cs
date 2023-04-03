namespace Calculadora
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.txtbResultado = new System.Windows.Forms.TextBox();
            this.txtbNum1 = new System.Windows.Forms.TextBox();
            this.txtbNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstbHistorial = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnLimpiarHistorial = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.Location = new System.Drawing.Point(312, 48);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(62, 59);
            this.btnMultiplicar.TabIndex = 0;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.Location = new System.Drawing.Point(312, 113);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(62, 59);
            this.btnDivision.TabIndex = 0;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPorcentaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorcentaje.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentaje.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPorcentaje.Location = new System.Drawing.Point(239, 113);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(63, 59);
            this.btnPorcentaje.TabIndex = 0;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // txtbResultado
            // 
            this.txtbResultado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtbResultado.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbResultado.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtbResultado.Location = new System.Drawing.Point(12, 178);
            this.txtbResultado.Name = "txtbResultado";
            this.txtbResultado.ReadOnly = true;
            this.txtbResultado.Size = new System.Drawing.Size(203, 39);
            this.txtbResultado.TabIndex = 1;
            this.txtbResultado.Text = "0";
            this.txtbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbNum1
            // 
            this.txtbNum1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtbNum1.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbNum1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtbNum1.Location = new System.Drawing.Point(12, 48);
            this.txtbNum1.Name = "txtbNum1";
            this.txtbNum1.Size = new System.Drawing.Size(203, 39);
            this.txtbNum1.TabIndex = 0;
            this.txtbNum1.Text = "0";
            this.txtbNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNum1_KeyPress);
            // 
            // txtbNum2
            // 
            this.txtbNum2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtbNum2.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbNum2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtbNum2.Location = new System.Drawing.Point(12, 113);
            this.txtbNum2.Name = "txtbNum2";
            this.txtbNum2.Size = new System.Drawing.Size(203, 39);
            this.txtbNum2.TabIndex = 1;
            this.txtbNum2.Text = "0";
            this.txtbNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNum2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Segundo Numero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Numero";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstbHistorial
            // 
            this.lstbHistorial.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lstbHistorial.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstbHistorial.FormattingEnabled = true;
            this.lstbHistorial.ItemHeight = 16;
            this.lstbHistorial.Location = new System.Drawing.Point(12, 284);
            this.lstbHistorial.Name = "lstbHistorial";
            this.lstbHistorial.Size = new System.Drawing.Size(203, 132);
            this.lstbHistorial.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Historial";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRestar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestar.Location = new System.Drawing.Point(239, 178);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(62, 59);
            this.btnRestar.TabIndex = 4;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSuma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.Location = new System.Drawing.Point(312, 178);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(62, 59);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnLimpiarHistorial
            // 
            this.btnLimpiarHistorial.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarHistorial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarHistorial.FlatAppearance.BorderSize = 0;
            this.btnLimpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarHistorial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarHistorial.Location = new System.Drawing.Point(180, 261);
            this.btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            this.btnLimpiarHistorial.Size = new System.Drawing.Size(35, 24);
            this.btnLimpiarHistorial.TabIndex = 6;
            this.btnLimpiarHistorial.Text = "CLS";
            this.btnLimpiarHistorial.UseVisualStyleBackColor = false;
            this.btnLimpiarHistorial.Click += new System.EventHandler(this.btnLimpiarHistorial_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(239, 48);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 59);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAyuda.Location = new System.Drawing.Point(239, 243);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(135, 26);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            this.btnAyuda.MouseEnter += new System.EventHandler(this.btnAyuda_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiarHistorial);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.lstbHistorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNum1);
            this.Controls.Add(this.txtbNum2);
            this.Controls.Add(this.txtbResultado);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCalculadora_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCalculadora_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnMultiplicar;
        private Button btnDivision;
        private Button btnPorcentaje;
        private TextBox txtbResultado;
        private TextBox txtbNum1;
        private TextBox txtbNum2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstbHistorial;
        private Label label4;
        private Button btnRestar;
        private Button btnSuma;
        private Button btnLimpiarHistorial;
        private Button btnBorrar;
        private Button btnAyuda;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
    }
}