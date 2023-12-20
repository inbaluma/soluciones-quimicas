using FluentNHibernate.Mapping;
using SolucionesQuimicas.Entities;

namespace SolucionesQuimicas.Mappings;

public class SolucionMap : ClassMap<Solucion>
{
    public SolucionMap()
    {
        Id(x => x.ID);
        Map(x => x.solucion);
        Map(x => x.uso);
        HasMany(x => x.muestras)
            .Cascade.All();
    }
}
