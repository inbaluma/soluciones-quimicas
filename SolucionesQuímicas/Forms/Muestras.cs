using System.Data;
using NHibernate;
using SolucionesQuimicas.Entities;

namespace SolucionesQuimicas.Forms
{
    public partial class Muestras : Form
    {
        private Muestra? muestraSeleccionada;
        private ISession session;
        private static readonly string PANTALLA = "MUESTRAS";

        public Muestras(Usuario usuario)
        {
            InitializeComponent();
            session = ConexionBD.CreateSessionFactory().OpenSession();
            bool acceso = false;
            if (usuario.rol != null)
            {
                // Comprobamos los permisos
                var permisos = session.Query<Permiso>()
                    .Where(x => PANTALLA.Equals(x.pantalla) && usuario.rol.rolName.Equals(x.rol.rolName))
                    .ToArray();
                if (permisos.Length > 0)
                {
                    Permiso permiso = permisos[0];
                    if (permiso.acceso)
                        acceso = true;
                    if (!permiso.insertar)
                        insertarButton.Enabled = false;
                    if (!permiso.borrar)
                        borrarButton.Enabled = false;
                    if (!permiso.modificar)
                        actualizarButton.Enabled = false;
                }
            }
            if (acceso)
            {
                var soluciones = session.CreateCriteria(typeof(Solucion))
                .List<Solucion>();
                solucionListBox.DataSource = soluciones;
                updateDataGridView();
            }
            else
            {
                controlLabel.Text = "No tiene acceso a estos datos.";
            }
        }

        private void insertarButton_Click(object sender, EventArgs e)
        {
            using (var transaction = session.BeginTransaction())
            {
                Solucion solucion = (Solucion)solucionListBox.SelectedItem;
                if (solucion != null)
                {
                    Muestra muestra = new Muestra(solucion)
                    {
                        NIF_Paciente = nifTextBox.Text,
                        Cultivo = cultivoTextBox.Text,
                    };
                    session.SaveOrUpdate(solucion);

                    transaction.Commit();

                    setMuestraSeleccionada(muestra);

                    updateDataGridView();
                }
                else
                {
                    controlLabel.Text = "Para insertar una muestra debe seleccionar una solucion de la lista.";
                }
            }
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            if (muestraSeleccionada != null)
            {
                using (var transaction = session.BeginTransaction())
                {
                    muestraSeleccionada.Delete();
                    session.Delete(muestraSeleccionada);
                    setMuestraSeleccionada(null);

                    transaction.Commit();
                }
                updateDataGridView();
            }
            else
            {
                controlLabel.Text = "Seleccione una muestra para borrarla.";
            }
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows != null && rows.Count > 0)
            {
                Muestra? muestra = rows[0].DataBoundItem as Muestra;
                setMuestraSeleccionada(muestra);
            }
            controlLabel.Text = string.Empty;
            MessageBox.Show(muestraSeleccionada != null ? muestraSeleccionada.ID+"" : "null");
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            if (muestraSeleccionada != null)
            {
                using (var transaction = session.BeginTransaction())
                {
                    muestraSeleccionada.NIF_Paciente = nifTextBox.Text;
                    muestraSeleccionada.Cultivo = cultivoTextBox.Text;
                    muestraSeleccionada.cambiaSolucion((Solucion)solucionListBox.SelectedItem);

                    transaction.Commit();
                }
                updateDataGridView();
            }
            else
            {
                controlLabel.Text = "Seleccione una muestra para actualizarla.";
            }
        }

        private void setMuestraSeleccionada(Muestra? muestra)
        {
            if (muestra == null)
            {
                muestraSeleccionada = null;
                idTextBox.Text = string.Empty;
                nifTextBox.Text = string.Empty;
                cultivoTextBox.Text = string.Empty;
                solucionListBox.SelectedItem = null;
            }
            else
            {
                muestraSeleccionada = muestra;
                idTextBox.Text = "" + muestra.ID;
                nifTextBox.Text = muestra.NIF_Paciente;
                cultivoTextBox.Text = muestra.Cultivo;
                solucionListBox.SelectedItem = muestra.Solucion;
            }
        }
        private void updateDataGridView()
        {
            var muestras = session.CreateCriteria(typeof(Muestra))
                .List<Muestra>();
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = muestras;
        }

        private void Muestras_FormClosed(object sender, FormClosedEventArgs e)
        {
            session.Dispose();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            setMuestraSeleccionada(null);
        }
    }
}
