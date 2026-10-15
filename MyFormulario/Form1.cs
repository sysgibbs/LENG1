using System;
using System.Data;
using System.Windows.Forms;
using VideoFormulario.Datos;
using VideoFormulario.Modelo;

namespace VideoFormulario
{
    public partial class Form1 : Form
    {

        DataTable tabla;
        Usuario dato = new Usuario();

        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }


        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            grilla.DataSource = tabla;
        }


        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text)
            };

            dato.Guardar(modelo);

            Iniciar();
            Limpiar();
            Consultar();
        }


        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }
        }


        private void Limpiar()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
