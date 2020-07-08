using EFWindowsFormEjemplo01.Context;
using EFWindowsFormEjemplo01.Context.Repositories;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using Ninject.Modules;

namespace EFWindowsFormEjemplo01.Windows.Ninject
{
    public class Bindings:NinjectModule
    {
        public override void Load()
        {
            Bind<CursosDbContext>().ToSelf().InSingletonScope();
            Bind<IUnitOfWork>().To<UnitofWork>();

            Bind<IRepositorioAlumno>().To<RepositorioAlumnos>();
            Bind<IServicioAlumno>().To<ServicioAlumnos>();
        }
    }
}
