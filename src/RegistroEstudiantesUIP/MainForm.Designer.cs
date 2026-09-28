namespace RegistroEstudiantesUIP;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        grpRegistro = new GroupBox();
        cmbCarrera = new ComboBox();
        lblCarrera = new Label();
        txtNombre = new TextBox();
        lblNombre = new Label();
        txtId = new TextBox();
        lblId = new Label();
        btnLimpiar = new Button();
        btnAgregar = new Button();
        dgvEstudiantes = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colNombre = new DataGridViewTextBoxColumn();
        colCarrera = new DataGridViewTextBoxColumn();
        lblEstado = new Label();
        lblPie = new Label();
        grpRegistro.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitulo.Location = new Point(28, 20);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(283, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Registro de estudiantes";
        // 
        // grpRegistro
        // 
        grpRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpRegistro.Controls.Add(cmbCarrera);
        grpRegistro.Controls.Add(lblCarrera);
        grpRegistro.Controls.Add(txtNombre);
        grpRegistro.Controls.Add(lblNombre);
        grpRegistro.Controls.Add(txtId);
        grpRegistro.Controls.Add(lblId);
        grpRegistro.Controls.Add(btnLimpiar);
        grpRegistro.Controls.Add(btnAgregar);
        grpRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        grpRegistro.Location = new Point(28, 69);
        grpRegistro.Name = "grpRegistro";
        grpRegistro.Size = new Size(824, 145);
        grpRegistro.TabIndex = 1;
        grpRegistro.TabStop = false;
        grpRegistro.Text = "Nuevo registro";
        // 
        // cmbCarrera
        // 
        cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCarrera.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        cmbCarrera.FormattingEnabled = true;
        cmbCarrera.Items.AddRange(new object[] { "Ingeniería en Sistemas Computacionales", "Administración de Empresas", "Contabilidad", "Mercadeo", "Otra" });
        cmbCarrera.Location = new Point(499, 48);
        cmbCarrera.Name = "cmbCarrera";
        cmbCarrera.Size = new Size(296, 25);
        cmbCarrera.TabIndex = 5;
        // 
        // lblCarrera
        // 
        lblCarrera.AutoSize = true;
        lblCarrera.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblCarrera.Location = new Point(499, 27);
        lblCarrera.Name = "lblCarrera";
        lblCarrera.Size = new Size(52, 17);
        lblCarrera.TabIndex = 4;
        lblCarrera.Text = "Carrera";
        // 
        // txtNombre
        // 
        txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtNombre.Location = new Point(181, 48);
        txtNombre.MaxLength = 80;
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Ej.: Ana Pérez";
        txtNombre.Size = new Size(285, 25);
        txtNombre.TabIndex = 3;
        // 
        // lblNombre
        // 
        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblNombre.Location = new Point(181, 27);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(56, 17);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre";
        // 
        // txtId
        // 
        txtId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtId.Location = new Point(21, 48);
        txtId.MaxLength = 10;
        txtId.Name = "txtId";
        txtId.PlaceholderText = "Ej.: 1001";
        txtId.Size = new Size(126, 25);
        txtId.TabIndex = 1;
        // 
        // lblId
        // 
        lblId.AutoSize = true;
        lblId.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblId.Location = new Point(21, 27);
        lblId.Name = "lblId";
        lblId.Size = new Size(86, 17);
        lblId.TabIndex = 0;
        lblId.Text = "ID estudiante";
        // 
        // btnLimpiar
        // 
        btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        btnLimpiar.Location = new Point(181, 91);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(126, 34);
        btnLimpiar.TabIndex = 7;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnAgregar
        // 
        btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnAgregar.Location = new Point(21, 91);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(126, 34);
        btnAgregar.TabIndex = 6;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = true;
        btnAgregar.Click += btnAgregar_Click;
        // 
        // dgvEstudiantes
        // 
        dgvEstudiantes.AllowUserToAddRows = false;
        dgvEstudiantes.AllowUserToDeleteRows = false;
        dgvEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEstudiantes.BackgroundColor = SystemColors.Window;
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colCarrera });
        dgvEstudiantes.Location = new Point(28, 255);
        dgvEstudiantes.MultiSelect = false;
        dgvEstudiantes.Name = "dgvEstudiantes";
        dgvEstudiantes.ReadOnly = true;
        dgvEstudiantes.RowHeadersVisible = false;
        dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEstudiantes.Size = new Size(824, 245);
        dgvEstudiantes.TabIndex = 2;
        // 
        // colId
        // 
        colId.FillWeight = 35F;
        colId.HeaderText = "ID";
        colId.Name = "colId";
        colId.ReadOnly = true;
        // 
        // colNombre
        // 
        colNombre.HeaderText = "Nombre";
        colNombre.Name = "colNombre";
        colNombre.ReadOnly = true;
        // 
        // colCarrera
        // 
        colCarrera.HeaderText = "Carrera";
        colCarrera.Name = "colCarrera";
        colCarrera.ReadOnly = true;
        // 
        // lblEstado
        // 
        lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblEstado.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblEstado.ForeColor = Color.DimGray;
        lblEstado.Location = new Point(28, 516);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(824, 24);
        lblEstado.TabIndex = 3;
        lblEstado.Text = "Complete los datos y presione Agregar.";
        // 
        // lblPie
        // 
        lblPie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPie.AutoSize = true;
        lblPie.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblPie.ForeColor = Color.DimGray;
        lblPie.Location = new Point(28, 552);
        lblPie.Name = "lblPie";
        lblPie.Size = new Size(274, 15);
        lblPie.TabIndex = 4;
        lblPie.Text = "Compiladores UIP · C# · WinForms · .NET 8";
        // 
        // MainForm
        // 
        AcceptButton = btnAgregar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(884, 586);
        Controls.Add(lblPie);
        Controls.Add(lblEstado);
        Controls.Add(dgvEstudiantes);
        Controls.Add(grpRegistro);
        Controls.Add(lblTitulo);
        MinimumSize = new Size(900, 625);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Registro de estudiantes - Compiladores UIP";
        grpRegistro.ResumeLayout(false);
        grpRegistro.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private GroupBox grpRegistro;
    private TextBox txtId;
    private Label lblId;
    private TextBox txtNombre;
    private Label lblNombre;
    private ComboBox cmbCarrera;
    private Label lblCarrera;
    private Button btnAgregar;
    private Button btnLimpiar;
    private DataGridView dgvEstudiantes;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colCarrera;
    private Label lblEstado;
    private Label lblPie;
}
