using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using MetroFramework.Controls;

namespace EFWindowsFormEjemplo01.Windows.Helpers
{
    public class Helper
    {
        public static void CargarDatosComboProfesores(ref MetroComboBox cbo)
        {
            IServicioProfesor servicioProfesor = new ServicioProfesores();
            var listaProfesores = servicioProfesor.GetProfesores();
            ProfesorListDto profesorDto = new ProfesorListDto
            {
                ProfesorId = 0,
                NombreCompleto = "<Seleccione un Profesor>"
            };
            listaProfesores.Insert(0, profesorDto);
            cbo.DataSource = listaProfesores;
            cbo.DisplayMember = "NombreCompleto";
            cbo.ValueMember = "ProfesorId";
            cbo.SelectedIndex = 0;

        }
    }
}
