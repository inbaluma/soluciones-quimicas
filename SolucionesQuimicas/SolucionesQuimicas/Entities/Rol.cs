namespace SolucionesQuimicas.Entities;
public class Rol
{
    public virtual string rolName { get; protected set; }
    public virtual string rolDes { get; set; }
    public virtual bool admin { get; set; }
    public virtual IList<Usuario> usuarios { get; protected set; }

    public Rol() {
    
        usuarios = new List<Usuario>();
    }

    public Rol(String name)
    {
        rolName = name;
        usuarios = new List<Usuario>();
    }

    public virtual void addUsuario(Usuario usuario)
    {
        usuario.rol = this;
        usuarios.Add(usuario);
    }
}
