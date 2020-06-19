using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
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

        public static void CargarDatosComboCursos(ref MetroComboBox cbo)
        {
            IServicioCurso servicio = new ServicioCursos();
            var lista = servicio.GetCursos();
            CursoListDto cursoDto = new CursoListDto
            {
                CursoId = 0,
                Nombre = "<Seleccione un Curso>"
            };
            lista.Insert(0, cursoDto);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "CursoId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarDatosComboAlumnos(ref MetroComboBox cbo)
        {
            IServicioAlumno servicio = new ServicioAlumnos();
            var lista = servicio.GetAlumnos();
            AlumnoListDto alumnoDto = new AlumnoListDto
            {
                AlumnoId = 0,
                NombreCompleto = "<Seleccione un Alumno>"
            };
            lista.Insert(0, alumnoDto);
            cbo.DataSource = lista;
            cbo.DisplayMember = "NombreCompleto";
            cbo.ValueMember = "AlumnoId";
            cbo.SelectedIndex = 0;
        }
    }
}
