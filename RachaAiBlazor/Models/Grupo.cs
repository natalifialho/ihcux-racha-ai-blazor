namespace RachaAiBlazor.Models
{
    public class Grupo
    {
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public decimal ValorPendente { get; set; }
        // true = eu devo (vermelho) | false = eu recebo (verde)
        public bool NoVermelho { get; set; } 
    }
}