namespace Clinica.Poco
{
    public class ConsultaPoco
    {
        public int CodigoConsulta { get; set; }
        public string Historico { get; set; } = null!;
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime DataHora { get; set; }
        public bool? Situacao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
