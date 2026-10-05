using RegistroEstudiantesUIP.Services;

namespace RegistroEstudiantesUIP;

public partial class MainForm : Form
{
    private readonly RegistroEstudiantesService _registroService = new();
    private int? _idSeleccionado;

    public MainForm()
    {
        InitializeComponent();
        cmbCarrera.SelectedIndex = 0;
        RestablecerSeleccion();
        ActualizarTabla();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        var resultado = _registroService.Registrar(
            txtId.Text,
            txtNombre.Text,
            cmbCarrera.Text);

        MostrarEstado(resultado.Mensaje, esError: !resultado.Exito);

        if (!resultado.Exito)
        {
            return;
        }

        ActualizarTabla();
        LimpiarFormulario();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        if (_idSeleccionado is null)
        {
            MostrarEstado("Seleccione un estudiante para actualizar.", esError: true);
            return;
        }

        var resultado = _registroService.Actualizar(
            _idSeleccionado.Value,
            txtId.Text,
            txtNombre.Text,
            cmbCarrera.Text);

        MostrarEstado(resultado.Mensaje, esError: !resultado.Exito);

        if (!resultado.Exito)
        {
            return;
        }

        ActualizarTabla();
        LimpiarFormulario();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (_idSeleccionado is null)
        {
            MostrarEstado("Seleccione un estudiante para eliminar.", esError: true);
            return;
        }

        DialogResult confirmacion = MessageBox.Show(
            "¿Desea eliminar el registro seleccionado?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

        if (confirmacion != DialogResult.Yes)
        {
            MostrarEstado("Eliminación cancelada.", esError: false);
            return;
        }

        var resultado = _registroService.Eliminar(_idSeleccionado.Value);
        MostrarEstado(resultado.Mensaje, esError: !resultado.Exito);

        if (!resultado.Exito)
        {
            return;
        }

        ActualizarTabla();
        LimpiarFormulario();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
        MostrarEstado(
            "Formulario limpio. Listo para un nuevo registro.",
            esError: false);
    }

    private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        DataGridViewRow fila = dgvEstudiantes.Rows[e.RowIndex];
        if (!int.TryParse(fila.Cells[colId.Index].Value?.ToString(), out int id))
        {
            return;
        }

        _idSeleccionado = id;
        txtId.Text = fila.Cells[colId.Index].Value?.ToString() ?? string.Empty;
        txtNombre.Text = fila.Cells[colNombre.Index].Value?.ToString() ?? string.Empty;

        string carrera = fila.Cells[colCarrera.Index].Value?.ToString() ?? string.Empty;
        int indiceCarrera = cmbCarrera.FindStringExact(carrera);
        if (indiceCarrera >= 0)
        {
            cmbCarrera.SelectedIndex = indiceCarrera;
        }

        grpRegistro.Text = "Editar registro seleccionado";
        btnActualizar.Enabled = true;
        btnEliminar.Enabled = true;
        MostrarEstado("Registro seleccionado. Puede actualizarlo o eliminarlo.", esError: false);
    }

    private void LimpiarFormulario()
    {
        txtId.Clear();
        txtNombre.Clear();
        cmbCarrera.SelectedIndex = 0;
        dgvEstudiantes.ClearSelection();
        RestablecerSeleccion();
        txtId.Focus();
    }

    private void RestablecerSeleccion()
    {
        _idSeleccionado = null;
        grpRegistro.Text = "Nuevo registro";
        btnActualizar.Enabled = false;
        btnEliminar.Enabled = false;
    }

    private void ActualizarTabla()
    {
        dgvEstudiantes.Rows.Clear();

        foreach (var estudiante in _registroService.Estudiantes)
        {
            dgvEstudiantes.Rows.Add(
                estudiante.Id,
                estudiante.Nombre,
                estudiante.Carrera);
        }

        ActualizarContador();
        dgvEstudiantes.ClearSelection();
    }

    private void ActualizarContador()
    {
        lblContador.Text = $"Registros: {_registroService.Estudiantes.Count}";
    }

    private void MostrarEstado(string mensaje, bool esError)
    {
        lblEstado.Text = mensaje;
        lblEstado.ForeColor = esError
            ? Color.FromArgb(176, 40, 40)
            : Color.FromArgb(31, 105, 74);
    }
}
