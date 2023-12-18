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
using SolucionesQuimicas;
using SolucionesQuimicas.Entities;

namespace Vista
{
    public partial class Bienvenido : Form
    {
        private ISessionFactory sessionFactory;
        public Bienvenido()
        {
            InitializeComponent();
            //sessionFactory = ConexionBD.CreateSessionFactory();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario("p") { password = "password" };
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            usuarioTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }
    }
}
