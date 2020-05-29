using System.Data.Entity.ModelConfiguration;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Context.EntityTypeConfigurations
{
    public class InscripcionEntityTypeConfigurations:EntityTypeConfiguration<Inscripcion>
    {
        public InscripcionEntityTypeConfigurations()
        {
            ToTable("Inscripciones");
        }
    }
}
