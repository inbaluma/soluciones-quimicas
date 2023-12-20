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
