namespace EFWindowsFormEjemplo01.Entities.DTOs.Curso
{
    public class CursoMasInfoDto
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioTotal { get; set; }
        public string Nivel { get; set; }
        public int Vacantes { get; set; }
        public string Profesor { get; set; }

    }
}
