using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SolucionesQuímicas.Entities;

namespace SolucionesQuímicas.Mappings;

public class MuestraMap : ClassMap<Muestra>
{
    public MuestraMap() 
    {
        Id(x => x.ID);
        Map(x => x.NIF_Paciente);
        Map(x => x.Cultivo);
        References(x => x.Solucion);
    }
}
