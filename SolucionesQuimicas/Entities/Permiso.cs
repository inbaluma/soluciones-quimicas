namespace SolucionesQuimicas.Entities;
public class Permiso
{
    public virtual Rol rol { get; protected set; }
    public virtual string pantalla { get; protected set; }
    public virtual bool acceso { get; set; }
    public virtual bool insertar { get; set; }
    public virtual bool modificar { get; set; }
    public virtual bool borrar { get; set; }

    public Permiso() { }

    public Permiso(Rol rol, String pantalla, bool acceso, bool insertar, bool modificar, bool borrar)
    {
        this.rol = rol;
        this.pantalla = pantalla;
        rol.addPermiso(this);
        this.acceso = acceso;
        this.insertar = insertar;
        this.modificar = modificar;
        this.borrar = borrar;
    }

    public override bool Equals(object? obj)
    {
        bool equals = false;
        if (obj != null)
        {
            if (obj is Permiso objPermiso)
            {
                equals = objPermiso.rol.Equals(this.rol) && objPermiso.pantalla.Equals(this.pantalla);
            }
        }
        return equals;
    }

    public override int GetHashCode()
    {
        return rol.GetHashCode() + 4 * pantalla.GetHashCode();
    }
}
