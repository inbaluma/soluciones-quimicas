using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
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
            //.ExposeConfiguration(BuildSchema)
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

    public static void populateDataBase()
    {
        var sessionFactory = ConexionBD.CreateSessionFactory();

        using (var session = sessionFactory.OpenSession())
        {
            using (var transaction = session.BeginTransaction())
            {
                var admin = new Rol("Administrador") { admin = true };
                var quimico = new Rol("Quimico") { admin = false };
                var usuario = new Rol("Usuario") { admin = false };
                var invitado = new Rol("Invitado") { admin = false };

                var pepe = new Usuario("pepe") { password = "pepe" };
                var marta = new Usuario("marta") { password = "marta" };
                var antonio = new Usuario("antonio") { password = "antonio" };
                var ana = new Usuario("ana") { password = "ana" };

                admin.addUsuario(pepe);
                quimico.addUsuario(marta);
                usuario.addUsuario(antonio);
                invitado.addUsuario(ana);

                var permiso1 = new Permiso(admin, "MUESTRAS") { acceso = true, modificar = true, insertar = true, borrar = true };
                var permiso2 = new Permiso(quimico, "MUESTRAS") { acceso = true, modificar = false, insertar = true, borrar = false };
                var permiso3 = new Permiso(usuario, "MUESTRAS") { acceso = true, modificar = false, insertar = false, borrar = false };
                var permiso4 = new Permiso(invitado, "MUESTRAS") { acceso = false, modificar = false, insertar = false, borrar = false };

                session.SaveOrUpdate(admin);
                session.SaveOrUpdate(quimico);
                session.SaveOrUpdate(usuario);
                session.SaveOrUpdate(invitado);


                var muestra1 = new Muestra { NIF_Paciente = "11111111A", Cultivo = "SANGRE" };
                var muestra2 = new Muestra { NIF_Paciente = "22222222B", Cultivo = "orina" };

                var solucion1 = new Solucion { solucion = "Azul de metileno" };
                var solucion2 = new Solucion { solucion = "Colorante" };

                solucion1.AddMuestra(muestra1);
                solucion2.AddMuestra(muestra2);

                session.SaveOrUpdate(solucion1);
                session.SaveOrUpdate(solucion2);

                transaction.Commit();
            }
        }

    }
}
