namespace blazor_application_calcular_imc.Models
{
    public class Pessoa
    {
        public int? Id { get; set; }
        public string? Nome {  get; set; }
        public double? Peso { get; set; }
        public double? Altura { get; set; }
        public double? ResultadoIMC {  get; set; }
        public string? ClassificacaoIMC { get; set; }

    }
}
