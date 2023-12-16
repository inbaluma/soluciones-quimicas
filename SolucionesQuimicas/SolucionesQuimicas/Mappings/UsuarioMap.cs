using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SolucionesQuimicas.Entities;

namespace SolucionesQuimicas.Mappings;

public class UsuarioMap : ClassMap<Usuario>
{
    public UsuarioMap() 
    {
        Id(x => x.nif);
        Map(x => x.password);
        References(x => x.rol);
    }
}
