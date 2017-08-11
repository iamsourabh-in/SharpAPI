using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using Resolver;
using BusinessServices;
using DataModel.UnitOfWork;

namespace WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();          
            // container.RegisterType<IProductServices, ProductServices>().RegisterType<UnitOfWork>(new HierarchicalLifetimeManager());

            RegisterTypes(container);
            // container.RegisterType<IProductServices, ProductServices>().RegisterType<UnitOfWork>(new HierarchicalLifetimeManager());

        }
        public static void RegisterTypes(IUnityContainer container)
        {

            //Component initialization via MEF  


        }
    }
}