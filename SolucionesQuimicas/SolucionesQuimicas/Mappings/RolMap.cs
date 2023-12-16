using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
