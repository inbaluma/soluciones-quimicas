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
            .BuildSessionFactory();
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

                admin.addUsuario(pepe);
                quimico.addUsuario(marta);

                session.SaveOrUpdate(admin);
                session.SaveOrUpdate(quimico);

                transaction.Commit();
            }
        }

    }
}