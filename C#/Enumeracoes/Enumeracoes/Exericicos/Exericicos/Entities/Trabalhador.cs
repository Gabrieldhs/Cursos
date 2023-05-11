using Exericicos.Entities.Enums;

namespace Exericicos.Entities
{
    public class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public  double SalarioBase { get; set; }
    }
}
