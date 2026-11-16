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
            if (!Validar()) return;

            Calcular();
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
        private decimal Calcular()
        {
            string combustible = cmbCombustible.SelectedItem.ToString();
            decimal galones = nudGalones.Value;

            // Precio por galón con expresión switch
            decimal precio = combustible switch
            {
                "Premium" => 290m,
                "Regular" => 272m,
                "Gasoil" => 225m,
                _ => 0m
            };

            lstDetalle.Items.Clear();

            decimal total = galones * precio;
            lstDetalle.Items.Add($"{galones:0.0} gal × RD$ {precio:N2} = RD$ {total:N2}");

            // Regla 3: 20 galones o más, 2 % de descuento
            if (galones >= 20)
            {
                total = total * 0.98m;
                lstDetalle.Items.Add($"Descuento 20+ galones ?2 %: RD$ {total:N2}");
            }

            // Regla 4: tarjeta, 3 % más (después del descuento, regla 5)
            if (cmbPago.SelectedItem.ToString() == "Tarjeta")
            {
                total = total * 1.03m;
                lstDetalle.Items.Add($"Tarjeta +3 %: RD$ {total:N2}");
            }

            lstDetalle.Items.Add($"TOTAL: RD$ {total:N2}");

            return total;
        }

    }

    
}

