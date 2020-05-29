using System.Data.Entity.ModelConfiguration;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Context.EntityTypeConfigurations
{
    public class CursoEntityTypeConfigurations:EntityTypeConfiguration<Curso>
    {
        public CursoEntityTypeConfigurations()
        {
            ToTable("Cursos");
        }
    }
}
