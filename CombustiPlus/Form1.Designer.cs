namespace CombustiPlus
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
            grpNuevo = new GroupBox();
            btnDespachar = new Button();
            btnCotizar = new Button();
            cmbPago = new ComboBox();
            nudGalones = new NumericUpDown();
            cmbCombustible = new ComboBox();
            txtPlaca = new TextBox();
            lblPago = new Label();
            lblGalones = new Label();
            lblCombustible = new Label();
            lblPlaca = new Label();
            lstDetalle = new ListBox();
            lstDespacho = new ListBox();
            groupBox1 = new GroupBox();
            btnCombustible = new Button();
            groupBox2 = new GroupBox();
            lblResumen = new Label();
            grpNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpNuevo
            // 
            grpNuevo.Controls.Add(btnDespachar);
            grpNuevo.Controls.Add(btnCotizar);
            grpNuevo.Controls.Add(cmbPago);
            grpNuevo.Controls.Add(nudGalones);
            grpNuevo.Controls.Add(cmbCombustible);
            grpNuevo.Controls.Add(txtPlaca);
            grpNuevo.Controls.Add(lblPago);
            grpNuevo.Controls.Add(lblGalones);
            grpNuevo.Controls.Add(lblCombustible);
            grpNuevo.Controls.Add(lblPlaca);
            grpNuevo.Location = new Point(12, 12);
            grpNuevo.Name = "grpNuevo";
            grpNuevo.Size = new Size(324, 208);
            grpNuevo.TabIndex = 0;
            grpNuevo.TabStop = false;
            grpNuevo.Text = "Nuevo despacho";
            grpNuevo.Enter += grpNuevo_Enter;
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(128, 172);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(92, 30);
            btnDespachar.TabIndex = 9;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += btnDespachar_Click;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(7, 172);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(95, 30);
            btnCotizar.TabIndex = 8;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += button1_Click;
            // 
            // cmbPago
            // 
            cmbPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(117, 129);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(165, 23);
            cmbPago.TabIndex = 7;
            // 
            // nudGalones
            // 
            nudGalones.DecimalPlaces = 1;
            nudGalones.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudGalones.Location = new Point(117, 97);
            nudGalones.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(120, 23);
            nudGalones.TabIndex = 6;
            // 
            // cmbCombustible
            // 
            cmbCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Location = new Point(117, 61);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(165, 23);
            cmbCombustible.TabIndex = 5;
            cmbCombustible.SelectedIndexChanged += cmbCombustible_SelectedIndexChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(117, 22);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(165, 23);
            txtPlaca.TabIndex = 4;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(7, 132);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(34, 15);
            lblPago.TabIndex = 3;
            lblPago.Text = "Pago";
            // 
            // lblGalones
            // 
            lblGalones.AutoSize = true;
            lblGalones.Location = new Point(6, 99);
            lblGalones.Name = "lblGalones";
            lblGalones.Size = new Size(49, 15);
            lblGalones.TabIndex = 2;
            lblGalones.Text = "Galones";
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.Location = new Point(6, 64);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(75, 15);
            lblCombustible.TabIndex = 1;
            lblCombustible.Text = "Combustible";
            lblCombustible.Click += label2_Click;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(6, 28);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa";
            // 
            // lstDetalle
            // 
            lstDetalle.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(8, 22);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(316, 116);
            lstDetalle.TabIndex = 1;
            // 
            // lstDespacho
            // 
            lstDespacho.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDespacho.FormattingEnabled = true;
            lstDespacho.Location = new Point(15, 22);
            lstDespacho.Name = "lstDespacho";
            lstDespacho.Size = new Size(473, 214);
            lstDespacho.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCombustible);
            groupBox1.Controls.Add(lstDespacho);
            groupBox1.Location = new Point(363, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 285);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despachos del dia";
            // 
            // btnCombustible
            // 
            btnCombustible.Location = new Point(15, 242);
            btnCombustible.Name = "btnCombustible";
            btnCombustible.Size = new Size(179, 34);
            btnCombustible.TabIndex = 3;
            btnCombustible.Text = "Galones por combustible";
            btnCombustible.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstDetalle);
            groupBox2.Location = new Point(12, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 152);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(381, 321);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(38, 15);
            lblResumen.TabIndex = 5;
            lblResumen.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(lblResumen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grpNuevo);
            Name = "Form1";
            Text = "CombustiPlus — Estación Bávaro.";
            grpNuevo.ResumeLayout(false);
            grpNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpNuevo;
        private Label lblPago;
        private Label lblGalones;
        private Label lblCombustible;
        private Label lblPlaca;
        private Button btnDespachar;
        private Button btnCotizar;
        private ComboBox cmbPago;
        private NumericUpDown nudGalones;
        private ComboBox cmbCombustible;
        private TextBox txtPlaca;
        private ListBox lstDetalle;
        private ListBox lstDespacho;
        private GroupBox groupBox1;
        private Button btnCombustible;
        private GroupBox groupBox2;
        private Label lblResumen;
    }
}
