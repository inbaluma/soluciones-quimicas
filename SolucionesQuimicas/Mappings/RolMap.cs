using FluentNHibernate.Mapping;
using SolucionesQuimicas.Entities;

namespace SolucionesQuimicas.Mappings;

public class RolMap : ClassMap<Rol>
{
    public RolMap()
    {
        Id(x => x.rolName);
        Map(x => x.rolDes);
        Map(x => x.admin);
        HasMany(x => x.usuarios)
            .Cascade.All();
        HasMany(x => x.permisos)
            .Cascade.All();
    }
}
