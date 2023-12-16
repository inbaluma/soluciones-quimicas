using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using SolucionesQuimicas.Entities;
using NHibernate.Tool.hbm2ddl;

namespace SolucionesQuimicas;
public class Program
{
    private const string DbFile = "solucionesQuimicas.db";

    static void Main()
    {
        populateDataBase();

        var sessionFactory = CreateSessionFactory();
        
        using (var session = sessionFactory.OpenSession())
        {
            using (session.BeginTransaction())
            {
                var usuarios = session.CreateCriteria(typeof(Usuario))
                    .List<Usuario>();

                foreach (var usuario in usuarios)
                    Console.WriteLine(usuario.ToString());
            }
        }
    }

    public static ISessionFactory CreateSessionFactory()
    {

        return Fluently.Configure()
            .Database(SQLiteConfiguration.Standard
                .UsingFile(DbFile))
            .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<Program>())
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

    private static void populateDataBase()
    {
        var sessionFactory = CreateSessionFactory();

        using (var session = sessionFactory.OpenSession())
        {
            using (var transaction = session.BeginTransaction())
            {
                var admin = new Rol("Admin") { admin = true };
                var quimico = new Rol("Quimico") { admin = false };

                var pepe = new Usuario("pepe") { password = "pepe" };
                var marta = new Usuario("marta") { password = "marta" };

                var permiso1 = new Permiso(admin, "PANTALLA") { acceso = true, modificar = true, insertar = true, borrar = true };
                var permiso2 = new Permiso(quimico, "PANTALLA") { acceso = true, modificar = false, insertar = true, borrar = false };

                admin.addUsuario(pepe);
                quimico.addUsuario(marta);

                admin.addPermiso(permiso1);
                quimico.addPermiso(permiso2);

                session.SaveOrUpdate(admin);
                session.SaveOrUpdate(quimico);

                transaction.Commit();
            }
        }

        using (var session = sessionFactory.OpenSession())
        {
            using (session.BeginTransaction())
            {
                var usuarios = session.CreateCriteria(typeof(Usuario))
                    .List<Usuario>();

                foreach (var usuario in usuarios)
                    Console.WriteLine(usuario.ToString());

                foreach(var permiso in session.CreateCriteria(typeof(Permiso)).List<Permiso>())
                    Console.WriteLine(permiso.ToString());
            }
        }

    }
}