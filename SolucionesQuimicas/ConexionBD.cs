using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SolucionesQuimicas.Entities;

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
            .BuildSessionFactory();
    }

    public static void populateDataBase()
    {
        var sessionFactory = ConexionBD.CreateSessionFactory();

        using (var session = sessionFactory.OpenSession())
        {
            using (var transaction = session.BeginTransaction())
            {
                var admin = new Rol("Administrador", true);
                var quimico = new Rol("Quimico", false);
                var usuario = new Rol("Usuario", false);
                var invitado = new Rol("Invitado", false);

                var pepe = new Usuario("pepe", "pepe", admin);
                var marta = new Usuario("marta", "marta", quimico);
                var antonio = new Usuario("antonio", "antonio", usuario);
                var ana = new Usuario("ana", "ana", invitado);

                var permiso1 = new Permiso(admin, "MUESTRAS", true, true, true, true);
                var permiso2 = new Permiso(quimico, "MUESTRAS", true, true, false, false);
                var permiso3 = new Permiso(usuario, "MUESTRAS", true, false, false, false);
                var permiso4 = new Permiso(invitado, "MUESTRAS", false, false, false, false);

                session.SaveOrUpdate(admin);
                session.SaveOrUpdate(quimico);
                session.SaveOrUpdate(usuario);
                session.SaveOrUpdate(invitado);


                var solucion1 = new Solucion { solucion = "Azul de metileno" };
                var solucion2 = new Solucion { solucion = "Colorante" };

                var muestra1 = new Muestra(solucion1) { NIF_Paciente = "11111111A", Cultivo = "SANGRE" };
                var muestra2 = new Muestra(solucion2) { NIF_Paciente = "22222222B", Cultivo = "orina" };

                session.SaveOrUpdate(solucion1);
                session.SaveOrUpdate(solucion2);

                transaction.Commit();
            }
        }

    }
}
