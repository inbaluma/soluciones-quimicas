namespace SolucionesQuimicas.Entities;

public class Usuario
{
    public virtual string nif { get; protected set; }
    public virtual string password { get; set; }
    public virtual Rol rol { get; set; }

    public Usuario()
    {

    }

    public Usuario(string nif, string password, Rol rol)
    {
        this.nif = nif;
        this.password = password;
        rol.addUsuario(this);
    }

    public override string ToString()
    {
        return nif + "; " + password + "; " + rol.rolName;
    }
}
