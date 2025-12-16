namespace SISTEMA_COBRO
{
    partial class Pagos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prestamoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaInteresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazoMesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaPrestamosDBDataSet = new SISTEMA_COBRO.SistemaPrestamosDBDataSet();
            this.prestamosTableAdapter = new SISTEMA_COBRO.SistemaPrestamosDBDataSetTableAdapters.PrestamosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaPrestamosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prestamoIDDataGridViewTextBoxColumn,
            this.clienteIDDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.tasaInteresDataGridViewTextBoxColumn,
            this.plazoMesesDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.formaPagoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prestamosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // prestamoIDDataGridViewTextBoxColumn
            // 
            this.prestamoIDDataGridViewTextBoxColumn.DataPropertyName = "PrestamoID";
            this.prestamoIDDataGridViewTextBoxColumn.HeaderText = "PrestamoID";
            this.prestamoIDDataGridViewTextBoxColumn.Name = "prestamoIDDataGridViewTextBoxColumn";
            this.prestamoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // tasaInteresDataGridViewTextBoxColumn
            // 
            this.tasaInteresDataGridViewTextBoxColumn.DataPropertyName = "TasaInteres";
            this.tasaInteresDataGridViewTextBoxColumn.HeaderText = "TasaInteres";
            this.tasaInteresDataGridViewTextBoxColumn.Name = "tasaInteresDataGridViewTextBoxColumn";
            // 
            // plazoMesesDataGridViewTextBoxColumn
            // 
            this.plazoMesesDataGridViewTextBoxColumn.DataPropertyName = "PlazoMeses";
            this.plazoMesesDataGridViewTextBoxColumn.HeaderText = "PlazoMeses";
            this.plazoMesesDataGridViewTextBoxColumn.Name = "plazoMesesDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // formaPagoDataGridViewTextBoxColumn
            // 
            this.formaPagoDataGridViewTextBoxColumn.DataPropertyName = "FormaPago";
            this.formaPagoDataGridViewTextBoxColumn.HeaderText = "FormaPago";
            this.formaPagoDataGridViewTextBoxColumn.Name = "formaPagoDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.sistemaPrestamosDBDataSet;
            // 
            // sistemaPrestamosDBDataSet
            // 
            this.sistemaPrestamosDBDataSet.DataSetName = "SistemaPrestamosDBDataSet";
            this.sistemaPrestamosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pago";
            // 
            // txtPagar
            // 
            this.txtPagar.Location = new System.Drawing.Point(36, 377);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(177, 20);
            this.txtPagar.TabIndex = 5;
            this.txtPagar.TextChanged += new System.EventHandler(this.txtPagar_TextChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(36, 456);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(105, 33);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 579);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaPrestamosDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SistemaPrestamosDBDataSet sistemaPrestamosDBDataSet;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private SistemaPrestamosDBDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestamoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaInteresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazoMesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Button btnPagar;
    }
}