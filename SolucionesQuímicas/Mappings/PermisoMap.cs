using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SolucionesQuímicas.Entities;

namespace SolucionesQuímicas.Mappings;

public class PermisoMap : ClassMap<Permiso>
{
    public PermisoMap() 
    {
        Id(x => x.id);
        References(x => x.rol);
        Map(x => x.pantalla, "Pantalla");
        Map(x => x.acceso);
        Map(x => x.insertar);
        Map(x => x.modificar);
        Map(x => x.borrar);
    }
}
