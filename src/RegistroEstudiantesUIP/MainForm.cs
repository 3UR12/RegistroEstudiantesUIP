using RegistroEstudiantesUIP.Services;

namespace RegistroEstudiantesUIP;

public partial class MainForm : Form
{
    private readonly RegistroEstudiantesService _registroService = new();

    public MainForm()
    {
        InitializeComponent();
        cmbCarrera.SelectedIndex = 0;
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        var resultado = _registroService.Registrar(
            txtId.Text,
            txtNombre.Text,
            cmbCarrera.Text);

        MostrarEstado(resultado.Mensaje, esError: !resultado.Exito);

        if (!resultado.Exito || resultado.Estudiante is null)
        {
            return;
        }

        var estudiante = resultado.Estudiante;

        dgvEstudiantes.Rows.Add(
            estudiante.Id,
            estudiante.Nombre,
            estudiante.Carrera);

        LimpiarFormulario();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
        MostrarEstado(
            "Formulario limpio. Listo para un nuevo registro.",
            esError: false);
    }

    private void LimpiarFormulario()
    {
        txtId.Clear();
        txtNombre.Clear();
        cmbCarrera.SelectedIndex = 0;
        txtId.Focus();
    }

    private void MostrarEstado(string mensaje, bool esError)
    {
        lblEstado.Text = mensaje;
        lblEstado.ForeColor = esError ? Color.Firebrick : Color.DarkGreen;
    }
}
