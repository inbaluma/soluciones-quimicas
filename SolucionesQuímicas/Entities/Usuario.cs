namespace SolucionesQuímicas.Entities;

public class Usuario
{
    public virtual string nif { get; protected set; }
    public virtual string password { get; set; }
    public virtual Rol rol { get; set; }

    public Usuario()
    {

    }

    public Usuario(String nif)
    {
        this.nif = nif;
    }

    public override string ToString()
    {
        return nif + "; " + password + "; " + rol.rolName;
    }
}
