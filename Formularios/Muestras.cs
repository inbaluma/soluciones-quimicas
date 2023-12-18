using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Util;
using SolucionesQuimicas;
using SolucionesQuimicas.Entities;



namespace Formularios
{
    public partial class Muestras : Form
    {
        private ISessionFactory sessionFactory;
        private Muestra muestraSeleccionada;
        private ISession session;

        public Muestras()
        {
            InitializeComponent();
            sessionFactory = ConexionBD.CreateSessionFactory();
            session = sessionFactory.OpenSession();

            var soluciones = session.CreateCriteria(typeof(Solucion))
                .List<Solucion>();
            solucionListBox.DataSource = soluciones;
            updateDataGridView();
        }

        private void insertarButton_Click(object sender, EventArgs e)
        {
            using (var transaction = session.BeginTransaction())
            {
                Muestra muestra = new Muestra()
                {
                    NIF_Paciente = nifTextBox.Text,
                    Cultivo = cultivoTextBox.Text,
                };
                Solucion solucion = (Solucion)solucionListBox.SelectedItem;
                solucion.AddMuestra(muestra);
                session.SaveOrUpdate(solucion);

                transaction.Commit();
            }
            updateDataGridView();
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {

        }

        private void salirButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            using (var session = sessionFactory.OpenSession())
            {
                var rows = dataGridView1.SelectedRows;
                if (rows != null && rows.Count > 0)
                {
                    Muestra muestra = rows[0].DataBoundItem as Muestra;
                    setMuestraSeleccionada(muestra);
                }
            }
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {

        }

        private void setMuestraSeleccionada(Muestra muestra)
        {
            if (muestra == null)
            {
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
            dataGridView1.DataSource = muestras;
        }
    }
}
