namespace EFWindowsFormEjemplo01.Entities.DTOs.Curso
{
    public class CursoListDto
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioTotal { get; set; }
        public int Vacantes { get; set; }
        public string Profesor { get; set; }

    }
}
