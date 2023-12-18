using Microsoft.VisualBasic.ApplicationServices;
using NHibernate.Hql.Ast;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using SolucionesQuímicas;
using SolucionesQuímicas.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SolucionesQuímicas.Forms
{
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }
        private bool inDataBase()
        {
            bool solucion = false;

            var sessionFactory = ConexionBD.CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    foreach (var usuario in session.Query<Usuario>().Where
                    (x => x.nif == usuarioTextBox.Text && x.password == passwordTextBox.Text))
                    {

                        solucion = true;

                    }
                }
            }
            return solucion;
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            if (inDataBase() == true)
            {
                this.Hide();

                Muestras muestra = new Muestras();

                muestra.ShowDialog();

                this.Close();

            }

            else loginLabel.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            usuarioTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
