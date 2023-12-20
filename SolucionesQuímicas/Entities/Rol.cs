namespace SolucionesQuimicas.Entities;
public class Rol
{
    public virtual string rolName { get; protected set; }
    public virtual string? rolDes { get; set; }
    public virtual bool admin { get; set; }
    public virtual IList<Usuario> usuarios { get; protected set; }
    public virtual IList<Permiso> permisos { get; protected set; }

    public Rol()
    {
        usuarios = new List<Usuario>();
        permisos = new List<Permiso>();
    }

    public Rol(String name, bool admin)
    {
        rolName = name;
        usuarios = new List<Usuario>();
        permisos = new List<Permiso>();
        this.admin = admin;
    }

    public virtual void addUsuario(Usuario usuario)
    {
        usuario.rol = this;
        usuarios.Add(usuario);
    }

    public virtual void addPermiso(Permiso permiso)
    {
        permisos.Add(permiso);
    }
}
