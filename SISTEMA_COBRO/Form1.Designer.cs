namespace SISTEMA_COBRO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlMadre = new System.Windows.Forms.Panel();
            this.pnlPaneldeControl = new System.Windows.Forms.Panel();
            this.pnlTotalporCobrar = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlTotalPrestado = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlPrestamos = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.lblContadorClientes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtgTablaPrestamos = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMadre.SuspendLayout();
            this.pnlPaneldeControl.SuspendLayout();
            this.pnlTotalporCobrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlTotalPrestado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(89, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 39);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 56);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Préstamos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(130, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestión Integral de préstamos y Clientes";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(14, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(116, 33);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clientes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Préstamos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(380, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Pagos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pnlMadre
            // 
            this.pnlMadre.BackColor = System.Drawing.Color.White;
            this.pnlMadre.Controls.Add(this.label13);
            this.pnlMadre.Controls.Add(this.dataGridView1);
            this.pnlMadre.Controls.Add(this.label12);
            this.pnlMadre.Controls.Add(this.dtgTablaPrestamos);
            this.pnlMadre.Controls.Add(this.pnlPaneldeControl);
            this.pnlMadre.Location = new System.Drawing.Point(89, 161);
            this.pnlMadre.Name = "pnlMadre";
            this.pnlMadre.Size = new System.Drawing.Size(1073, 620);
            this.pnlMadre.TabIndex = 2;
            this.pnlMadre.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMadre_Paint);
            // 
            // pnlPaneldeControl
            // 
            this.pnlPaneldeControl.Controls.Add(this.pnlTotalporCobrar);
            this.pnlPaneldeControl.Controls.Add(this.pnlTotalPrestado);
            this.pnlPaneldeControl.Controls.Add(this.pnlPrestamos);
            this.pnlPaneldeControl.Controls.Add(this.pnlClientes);
            this.pnlPaneldeControl.Controls.Add(this.label4);
            this.pnlPaneldeControl.Controls.Add(this.label3);
            this.pnlPaneldeControl.Location = new System.Drawing.Point(3, 3);
            this.pnlPaneldeControl.Name = "pnlPaneldeControl";
            this.pnlPaneldeControl.Size = new System.Drawing.Size(1067, 194);
            this.pnlPaneldeControl.TabIndex = 0;
            // 
            // pnlTotalporCobrar
            // 
            this.pnlTotalporCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalporCobrar.Controls.Add(this.label10);
            this.pnlTotalporCobrar.Controls.Add(this.pictureBox5);
            this.pnlTotalporCobrar.Controls.Add(this.label11);
            this.pnlTotalporCobrar.Location = new System.Drawing.Point(770, 80);
            this.pnlTotalporCobrar.Name = "pnlTotalporCobrar";
            this.pnlTotalporCobrar.Size = new System.Drawing.Size(200, 100);
            this.pnlTotalporCobrar.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "$58,100.00";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(19, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(16, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total por Cobrar";
            // 
            // pnlTotalPrestado
            // 
            this.pnlTotalPrestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalPrestado.Controls.Add(this.label8);
            this.pnlTotalPrestado.Controls.Add(this.pictureBox4);
            this.pnlTotalPrestado.Controls.Add(this.label9);
            this.pnlTotalPrestado.Location = new System.Drawing.Point(507, 80);
            this.pnlTotalPrestado.Name = "pnlTotalPrestado";
            this.pnlTotalPrestado.Size = new System.Drawing.Size(200, 100);
            this.pnlTotalPrestado.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "$80,000.00";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(16, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total Prestado";
            // 
            // pnlPrestamos
            // 
            this.pnlPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrestamos.Controls.Add(this.label6);
            this.pnlPrestamos.Controls.Add(this.pictureBox3);
            this.pnlPrestamos.Controls.Add(this.label7);
            this.pnlPrestamos.Location = new System.Drawing.Point(254, 80);
            this.pnlPrestamos.Name = "pnlPrestamos";
            this.pnlPrestamos.Size = new System.Drawing.Size(200, 100);
            this.pnlPrestamos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(14, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Préstamos Activos";
            // 
            // pnlClientes
            // 
            this.pnlClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientes.Controls.Add(this.lblContadorClientes);
            this.pnlClientes.Controls.Add(this.label5);
            this.pnlClientes.Controls.Add(this.pictureBox2);
            this.pnlClientes.Location = new System.Drawing.Point(11, 80);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(200, 100);
            this.pnlClientes.TabIndex = 8;
            // 
            // lblContadorClientes
            // 
            this.lblContadorClientes.AutoSize = true;
            this.lblContadorClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorClientes.ForeColor = System.Drawing.Color.Black;
            this.lblContadorClientes.Location = new System.Drawing.Point(10, 55);
            this.lblContadorClientes.Name = "lblContadorClientes";
            this.lblContadorClientes.Size = new System.Drawing.Size(15, 17);
            this.lblContadorClientes.TabIndex = 4;
            this.lblContadorClientes.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Clientes Registrados";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resumen general del sistema";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Panel de Control";
            // 
            // dtgTablaPrestamos
            // 
            this.dtgTablaPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dtgTablaPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTablaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTablaPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.Monto,
            this.Interes,
            this.Total,
            this.Balance,
            this.Vencimiento});
            this.dtgTablaPrestamos.GridColor = System.Drawing.Color.Gray;
            this.dtgTablaPrestamos.Location = new System.Drawing.Point(20, 239);
            this.dtgTablaPrestamos.Name = "dtgTablaPrestamos";
            this.dtgTablaPrestamos.Size = new System.Drawing.Size(1040, 150);
            this.dtgTablaPrestamos.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(11, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Prestamos Activos";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Interes
            // 
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // Vencimiento
            // 
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(11, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ultimos Pagos Registrados";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(20, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1040, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Pago";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Prestamo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Monto Pagado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 793);
            this.Controls.Add(this.pnlMadre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMadre.ResumeLayout(false);
            this.pnlMadre.PerformLayout();
            this.pnlPaneldeControl.ResumeLayout(false);
            this.pnlPaneldeControl.PerformLayout();
            this.pnlTotalporCobrar.ResumeLayout(false);
            this.pnlTotalporCobrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlTotalPrestado.ResumeLayout(false);
            this.pnlTotalPrestado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlPrestamos.ResumeLayout(false);
            this.pnlPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTablaPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlMadre;
        private System.Windows.Forms.Panel pnlPaneldeControl;
        private System.Windows.Forms.Panel pnlTotalporCobrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlTotalPrestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlPrestamos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Label lblContadorClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgTablaPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

