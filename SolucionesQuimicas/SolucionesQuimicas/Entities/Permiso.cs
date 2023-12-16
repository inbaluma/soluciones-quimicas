namespace SolucionesQuimicas.Entities;
public class Permiso
{
    public virtual int id { get; protected set; }
    public virtual Rol rol { get; protected set; }
    public virtual string pantalla { get; protected set; }
    public virtual bool acceso { get; set; }
    public virtual bool insertar { get; set; }
    public virtual bool modificar { get; set; }
    public virtual bool borrar { get; set; }

    public Permiso() {    }

    public Permiso(Rol rol, String pantalla)
    {
        this.rol = rol;
        this.pantalla = pantalla;
    }

    public override string ToString()
    {
        return $"{rol.rolName}, {pantalla}, acceso: {acceso}, insertar: {insertar}, modificar: {modificar}, borrar: {borrar}";
    }
}
