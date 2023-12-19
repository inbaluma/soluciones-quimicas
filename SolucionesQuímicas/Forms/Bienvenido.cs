using System.Data;
using SolucionesQuimicas.Entities;

namespace SolucionesQuimicas.Forms
{
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }
        private Usuario getUsuario()
        {
            Usuario usuario = null;

            var sessionFactory = ConexionBD.CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                var usuarios = session.Query<Usuario>()
                    .Where(x => x.nif == usuarioTextBox.Text && x.password == passwordTextBox.Text)
                    .ToArray();
                if (usuarios.Length > 0)
                {
                    usuario = usuarios[0];
                }

            }
            return usuario;
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = getUsuario();
            if (usuario != null)
            {
                this.Hide();

                Muestras muestra = new Muestras(usuario);

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
