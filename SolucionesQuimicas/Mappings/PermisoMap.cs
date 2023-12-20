using FluentNHibernate.Mapping;
using SolucionesQuimicas.Entities;

namespace SolucionesQuimicas.Mappings;

public class PermisoMap : ClassMap<Permiso>
{
    public PermisoMap()
    {
        CompositeId()
            .KeyReference(x => x.rol, "id_rol")
            .KeyProperty(x => x.pantalla);
        Map(x => x.acceso);
        Map(x => x.insertar);
        Map(x => x.modificar);
        Map(x => x.borrar);
    }
}
