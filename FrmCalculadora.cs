namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        ClsOp Operacion = new ClsOp();

        



        public FrmCalculadora()
        {
            InitializeComponent();
        }

      
        public void operar(string o)
        {
            Operacion.Num1 = double.Parse(txtbNum1.Text);
            Operacion.Num2 = double.Parse(txtbNum2.Text);
            Operacion.AccionOperar(o);
            lstbHistorial.Items.Add(Operacion.Num1 + ""+ o +"" + Operacion.Num2 + " = " + Operacion.RES);
            txtbResultado.Text = Convert.ToString(Operacion.RES);
            txtbNum1.Text = "0";
            txtbNum2.Text = "0";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            

            try
            {
                operar("*");
            }
            catch (Exception ex) { MessageBox.Show("Formato incorrecto de números"); }


        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                operar("%");
            }
            catch (Exception ex) { MessageBox.Show("Formato incorrecto de números"); }

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            
            try
            {
                operar("/");
            }
            catch(Exception ex) { MessageBox.Show("Formato incorrecto de números"); }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                operar("-");
            }
            catch (Exception ex) { MessageBox.Show("Formato incorrecto de números"); }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                operar("+");
            }
            catch (Exception ex) { MessageBox.Show("Formato incorrecto de números"); }
           

            
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            lstbHistorial.Items.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtbNum1.Text = "0";
            txtbNum2.Text = "0";
            txtbResultado.Text = "0";
            txtbNum1.Focus();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin flogin = new FrmLogin();
            flogin.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda fayuda = new FrmAyuda();
            fayuda.Show();
        }

        

        private void txtbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {

                txtbNum2.Focus();
            }
            else if (e.KeyChar == (char)Keys.S)
            {
                btnSuma.PerformClick();
            }
        }

        private void FrmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.H) 
            {
                btnAyuda.PerformClick();
            }
            
        }

        private void txtbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnAyuda_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.btnAyuda, "Presiona Shift + h para mostrar información de la app");
        }
    }
}