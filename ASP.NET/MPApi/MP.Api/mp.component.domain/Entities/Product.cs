using mp.component.domain.Validations;

namespace mp.component.domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string CodErp { get; set; }
        public decimal Price { get; set; }
        public ICollection<Purchase> Purchases { get; set; }


        public Product(string name, string codErp, decimal price)
        {
            Validation(name, codErp, price);
        }

        public Product(int id, string name, string codErp, decimal price)
        {
            DomainValidationsException.When(id < 0, "Id do produto deve ser informado");
            Id = id;
            Validation(name, codErp, price);
        }

        public void Validation(string name, string codErp, decimal price)
        {
            DomainValidationsException.When(string.IsNullOrEmpty(name), "O nome é obrigatório");
            DomainValidationsException.When(string.IsNullOrEmpty(codErp), "O Cógido Erp é obrigatório");
            DomainValidationsException.When(price < 0, "O preço necessita ser informado");

            Name = name;
            CodErp = codErp;
            Price = price;
;       }
    }
}
