using mp.component.domain.Validations;

namespace mp.component.domain.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdPerson { get; set; }
        public DateTime Date { get; set; }
        public Person Person { get; set; }
        public Product Product { get; set; }

        public Purchase()
        {

        }
        public void Validation(int idProduct, int idPerson, DateTime? date)
        {
            DomainValidationsException.When(idProduct <= 0, "Id do produto deve ser informado");
            DomainValidationsException.When(idPerson <= 0, "Id pessoa deve ser informado");
            DomainValidationsException.When(date.HasValue, "A data deve ser informada");

            IdPerson = idProduct;
            IdPerson = idPerson;
            Date = date.Value;
        }
    }
}
