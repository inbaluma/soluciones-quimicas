using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using SolucionesQuimicas.Entities;
using NHibernate.Tool.hbm2ddl;

namespace SolucionesQuimicas;

public class ConexionBD
{
    private const string DbFile = "solucionesQuimicas.db";

    public static ISessionFactory CreateSessionFactory()
    {

        return Fluently.Configure()
            .Database(SQLiteConfiguration.Standard
                .UsingFile(DbFile))
            .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<ConexionBD>())
            .ExposeConfiguration(BuildSchema)
            .BuildSessionFactory();
    }

    private static void BuildSchema(Configuration config)
    {
        // delete the existing db on each run
        if (File.Exists(DbFile))
            File.Delete(DbFile);

        // this NHibernate tool takes a configuration (with mapping info in)
        // and exports a database schema from it
        new SchemaExport(config)
            .Create(false, true);
    }
}
