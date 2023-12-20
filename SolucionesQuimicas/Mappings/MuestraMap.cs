using FluentNHibernate.Mapping;
using SolucionesQuimicas.Entities;

namespace SolucionesQuimicas.Mappings;

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
