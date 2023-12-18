using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SolucionesQuímicas.Entities;

namespace SolucionesQuímicas.Mappings;

public class RolMap : ClassMap<Rol>
{
    public RolMap() 
    {
        Id(x => x.rolName);
        Map(x => x.rolDes);
        Map(x => x.admin);
        HasMany(x => x.usuarios)
            .Cascade.All();
        HasMany(x=>x.permisos) 
            .Cascade.All();
    }
}
