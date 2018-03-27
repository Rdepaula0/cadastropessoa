using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Configuration = NHibernate.Cfg.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CP.FrameWork
{
    public static class Database
    {
        public static bool ScreateSchema { get; set; }
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                try
                {
                    if (_sessionFactory == null)
                    {
                        var mapeamentoAssembly = ConfigurationManager.AppSettings["Mapping"];
                        var assembly = Assembly.Load(mapeamentoAssembly);

                        var configuration = new Configuration();
                        var dados = Fluently.Configure(configuration.Configure()).Mappings(m => m.FluentMappings.AddFromAssembly(assembly)).ExposeConfiguration(delegate (Configuration x)
                        {
                            if (ScreateSchema)
                            {
                                new SchemaUpdate(x).Execute(true, true);
                            }
                        });
                        _sessionFactory = dados.BuildSessionFactory();
                    }
                    return _sessionFactory;
                }
                catch (Exception ex)
                {
                    throw new ArgumentNullException(ex.Message);
                }

            }
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}

