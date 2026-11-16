namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grpNuevo_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCombustible_SelectedIndexChanged(object sender, EventArgs e)
     
        {
            InitializeComponent();

            cmbCombustible.Items.AddRange(new string[] { "Premium", "Regular", "Gasoil" });
            cmbPago.Items.AddRange(new string[] { "Efectivo", "Tarjeta" });

            cmbCombustible.SelectedIndex = 0;
            cmbPago.SelectedIndex = 0;


        }

        private bool Validar()
        {
            if (txtPlaca.Text.Trim().Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres.\nEjemplo: A123456",
                                "Placa inválida",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlaca.Focus();
                return false;
            }

            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("Los galones deben ser más de 0.",
                                "Galones inválidos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudGalones.Focus();
                return false;
            }

            return true;
        }

    }

    
}

