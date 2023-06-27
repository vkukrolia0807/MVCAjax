using Student_Crud_Ajax_Reposiyory.Repository;
using Student_Crud_Ajax_Reposiyory.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Student_Crud_Ajax
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IStudent, Studentservice>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}