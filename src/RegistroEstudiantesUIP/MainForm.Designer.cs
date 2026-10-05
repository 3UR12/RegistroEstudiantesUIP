#nullable enable

namespace RegistroEstudiantesUIP;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        DataGridViewCellStyle headerStyle = new();
        DataGridViewCellStyle rowStyle = new();
        DataGridViewCellStyle alternatingRowStyle = new();
        pnlHeader = new Panel();
        lblSubtitulo = new Label();
        lblTitulo = new Label();
        grpRegistro = new GroupBox();
        lblPrivacidad = new Label();
        cmbCarrera = new ComboBox();
        lblCarrera = new Label();
        txtNombre = new TextBox();
        lblNombre = new Label();
        txtId = new TextBox();
        lblId = new Label();
        btnLimpiar = new Button();
        btnEliminar = new Button();
        btnActualizar = new Button();
        btnAgregar = new Button();
        lblSeccionTabla = new Label();
        lblContador = new Label();
        dgvEstudiantes = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colNombre = new DataGridViewTextBoxColumn();
        colCarrera = new DataGridViewTextBoxColumn();
        lblEstado = new Label();
        lblPie = new Label();
        pnlHeader.SuspendLayout();
        grpRegistro.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
        SuspendLayout();

        pnlHeader.BackColor = Color.FromArgb(32, 50, 74);
        pnlHeader.Controls.Add(lblSubtitulo);
        pnlHeader.Controls.Add(lblTitulo);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(984, 96);
        pnlHeader.TabIndex = 0;

        lblSubtitulo.AutoSize = true;
        lblSubtitulo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblSubtitulo.ForeColor = Color.FromArgb(210, 219, 230);
        lblSubtitulo.Location = new Point(34, 61);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(326, 17);
        lblSubtitulo.TabIndex = 1;
        lblSubtitulo.Text = "Registro local · C# · Windows Forms · .NET 8";

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI Semibold", 21F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(31, 17);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(318, 38);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Registro de estudiantes";

        grpRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpRegistro.BackColor = Color.White;
        grpRegistro.Controls.Add(lblPrivacidad);
        grpRegistro.Controls.Add(cmbCarrera);
        grpRegistro.Controls.Add(lblCarrera);
        grpRegistro.Controls.Add(txtNombre);
        grpRegistro.Controls.Add(lblNombre);
        grpRegistro.Controls.Add(txtId);
        grpRegistro.Controls.Add(lblId);
        grpRegistro.Controls.Add(btnLimpiar);
        grpRegistro.Controls.Add(btnEliminar);
        grpRegistro.Controls.Add(btnActualizar);
        grpRegistro.Controls.Add(btnAgregar);
        grpRegistro.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
        grpRegistro.ForeColor = Color.FromArgb(37, 47, 61);
        grpRegistro.Location = new Point(32, 119);
        grpRegistro.Name = "grpRegistro";
        grpRegistro.Size = new Size(920, 206);
        grpRegistro.TabIndex = 1;
        grpRegistro.TabStop = false;
        grpRegistro.Text = "Nuevo registro";

        lblPrivacidad.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblPrivacidad.ForeColor = Color.FromArgb(92, 103, 117);
        lblPrivacidad.Location = new Point(28, 157);
        lblPrivacidad.Name = "lblPrivacidad";
        lblPrivacidad.Size = new Size(860, 32);
        lblPrivacidad.TabIndex = 10;
        lblPrivacidad.Text = "Privacidad: los datos son temporales, no se guardan ni se envían. Utilice información de práctica y evite datos personales reales.";

        cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCarrera.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        cmbCarrera.FormattingEnabled = true;
        cmbCarrera.Items.AddRange(new object[] { "Ingeniería en Sistemas Computacionales", "Administración de Empresas", "Contabilidad", "Mercadeo", "Otra" });
        cmbCarrera.Location = new Point(581, 55);
        cmbCarrera.Name = "cmbCarrera";
        cmbCarrera.Size = new Size(307, 25);
        cmbCarrera.TabIndex = 5;

        lblCarrera.AutoSize = true;
        lblCarrera.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblCarrera.Location = new Point(581, 32);
        lblCarrera.Name = "lblCarrera";
        lblCarrera.Size = new Size(52, 17);
        lblCarrera.TabIndex = 4;
        lblCarrera.Text = "Carrera";

        txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtNombre.Location = new Point(220, 55);
        txtNombre.MaxLength = 80;
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Ej.: Ana Pérez";
        txtNombre.Size = new Size(320, 25);
        txtNombre.TabIndex = 3;

        lblNombre.AutoSize = true;
        lblNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblNombre.Location = new Point(220, 32);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(56, 17);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre";

        txtId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        txtId.Location = new Point(28, 55);
        txtId.MaxLength = 10;
        txtId.Name = "txtId";
        txtId.PlaceholderText = "Ej.: 1001";
        txtId.Size = new Size(150, 25);
        txtId.TabIndex = 1;

        lblId.AutoSize = true;
        lblId.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblId.Location = new Point(28, 32);
        lblId.Name = "lblId";
        lblId.Size = new Size(86, 17);
        lblId.TabIndex = 0;
        lblId.Text = "ID estudiante";

        btnAgregar.BackColor = Color.FromArgb(31, 78, 121);
        btnAgregar.FlatAppearance.BorderSize = 0;
        btnAgregar.FlatStyle = FlatStyle.Flat;
        btnAgregar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnAgregar.ForeColor = Color.White;
        btnAgregar.Location = new Point(28, 105);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(140, 38);
        btnAgregar.TabIndex = 6;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = false;
        btnAgregar.Click += btnAgregar_Click;

        btnActualizar.BackColor = Color.FromArgb(52, 98, 68);
        btnActualizar.FlatAppearance.BorderSize = 0;
        btnActualizar.FlatStyle = FlatStyle.Flat;
        btnActualizar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnActualizar.ForeColor = Color.White;
        btnActualizar.Location = new Point(178, 105);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(140, 38);
        btnActualizar.TabIndex = 7;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = false;
        btnActualizar.Click += btnActualizar_Click;

        btnEliminar.BackColor = Color.FromArgb(154, 53, 53);
        btnEliminar.FlatAppearance.BorderSize = 0;
        btnEliminar.FlatStyle = FlatStyle.Flat;
        btnEliminar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnEliminar.ForeColor = Color.White;
        btnEliminar.Location = new Point(328, 105);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(140, 38);
        btnEliminar.TabIndex = 8;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;

        btnLimpiar.BackColor = Color.White;
        btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(175, 184, 196);
        btnLimpiar.FlatStyle = FlatStyle.Flat;
        btnLimpiar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnLimpiar.ForeColor = Color.FromArgb(47, 59, 74);
        btnLimpiar.Location = new Point(478, 105);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(140, 38);
        btnLimpiar.TabIndex = 9;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += btnLimpiar_Click;

        lblSeccionTabla.AutoSize = true;
        lblSeccionTabla.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblSeccionTabla.ForeColor = Color.FromArgb(37, 47, 61);
        lblSeccionTabla.Location = new Point(32, 350);
        lblSeccionTabla.Name = "lblSeccionTabla";
        lblSeccionTabla.Size = new Size(169, 20);
        lblSeccionTabla.TabIndex = 2;
        lblSeccionTabla.Text = "Estudiantes registrados";

        lblContador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblContador.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblContador.ForeColor = Color.FromArgb(92, 103, 117);
        lblContador.Location = new Point(792, 350);
        lblContador.Name = "lblContador";
        lblContador.Size = new Size(160, 20);
        lblContador.TabIndex = 3;
        lblContador.Text = "Registros: 0";
        lblContador.TextAlign = ContentAlignment.MiddleRight;

        dgvEstudiantes.AllowUserToAddRows = false;
        dgvEstudiantes.AllowUserToDeleteRows = false;
        dgvEstudiantes.AllowUserToResizeRows = false;
        alternatingRowStyle.BackColor = Color.FromArgb(248, 250, 252);
        alternatingRowStyle.ForeColor = Color.FromArgb(37, 47, 61);
        dgvEstudiantes.AlternatingRowsDefaultCellStyle = alternatingRowStyle;
        dgvEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvEstudiantes.BackgroundColor = Color.White;
        dgvEstudiantes.BorderStyle = BorderStyle.FixedSingle;
        dgvEstudiantes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        headerStyle.BackColor = Color.FromArgb(32, 50, 74);
        headerStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        headerStyle.ForeColor = Color.White;
        headerStyle.SelectionBackColor = Color.FromArgb(32, 50, 74);
        headerStyle.SelectionForeColor = Color.White;
        headerStyle.WrapMode = DataGridViewTriState.True;
        dgvEstudiantes.ColumnHeadersDefaultCellStyle = headerStyle;
        dgvEstudiantes.ColumnHeadersHeight = 38;
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colCarrera });
        dgvEstudiantes.EnableHeadersVisualStyles = false;
        dgvEstudiantes.GridColor = Color.FromArgb(226, 231, 237);
        dgvEstudiantes.Location = new Point(32, 378);
        dgvEstudiantes.MultiSelect = false;
        dgvEstudiantes.Name = "dgvEstudiantes";
        dgvEstudiantes.ReadOnly = true;
        dgvEstudiantes.RowHeadersVisible = false;
        rowStyle.BackColor = Color.White;
        rowStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        rowStyle.ForeColor = Color.FromArgb(37, 47, 61);
        rowStyle.SelectionBackColor = Color.FromArgb(214, 229, 244);
        rowStyle.SelectionForeColor = Color.FromArgb(22, 45, 69);
        dgvEstudiantes.RowsDefaultCellStyle = rowStyle;
        dgvEstudiantes.RowTemplate.Height = 32;
        dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvEstudiantes.Size = new Size(920, 315);
        dgvEstudiantes.TabIndex = 4;
        dgvEstudiantes.CellClick += dgvEstudiantes_CellClick;

        colId.FillWeight = 35F;
        colId.HeaderText = "ID";
        colId.Name = "colId";
        colId.ReadOnly = true;

        colNombre.FillWeight = 95F;
        colNombre.HeaderText = "Nombre";
        colNombre.Name = "colNombre";
        colNombre.ReadOnly = true;

        colCarrera.FillWeight = 120F;
        colCarrera.HeaderText = "Carrera";
        colCarrera.Name = "colCarrera";
        colCarrera.ReadOnly = true;

        lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lblEstado.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblEstado.ForeColor = Color.FromArgb(92, 103, 117);
        lblEstado.Location = new Point(32, 710);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(920, 24);
        lblEstado.TabIndex = 5;
        lblEstado.Text = "Complete los datos y presione Agregar.";

        lblPie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPie.AutoSize = true;
        lblPie.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblPie.ForeColor = Color.FromArgb(112, 122, 135);
        lblPie.Location = new Point(32, 756);
        lblPie.Name = "lblPie";
        lblPie.Size = new Size(274, 15);
        lblPie.TabIndex = 6;
        lblPie.Text = "Compiladores UIP · C# · WinForms · .NET 8";

        AcceptButton = btnAgregar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(244, 247, 250);
        ClientSize = new Size(984, 790);
        Controls.Add(lblPie);
        Controls.Add(lblEstado);
        Controls.Add(dgvEstudiantes);
        Controls.Add(lblContador);
        Controls.Add(lblSeccionTabla);
        Controls.Add(grpRegistro);
        Controls.Add(pnlHeader);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        MinimumSize = new Size(900, 760);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Registro de estudiantes - Compiladores UIP";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        grpRegistro.ResumeLayout(false);
        grpRegistro.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel pnlHeader;
    private Label lblTitulo;
    private Label lblSubtitulo;
    private GroupBox grpRegistro;
    private TextBox txtId;
    private Label lblId;
    private TextBox txtNombre;
    private Label lblNombre;
    private ComboBox cmbCarrera;
    private Label lblCarrera;
    private Button btnAgregar;
    private Button btnActualizar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Label lblPrivacidad;
    private Label lblSeccionTabla;
    private Label lblContador;
    private DataGridView dgvEstudiantes;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colCarrera;
    private Label lblEstado;
    private Label lblPie;
}
