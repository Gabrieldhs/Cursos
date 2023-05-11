using mp.component.domain.Validations;

namespace mp.component.domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
        public ICollection<Purchase> Purchases { get; set; }

        public Person(string name, string document, string phone)
        {
            Validation(document,name,phone);
        }

        public Person(int id, string name, string document, string phone)
        {
            DomainValidationsException.When(id <= 0, "Id dever ser maior que 0");
            Id = id;
            Validation(name,document,phone);

        }

        public void Validation (string document, string name, string phone)
        {
            DomainValidationsException.When(string.IsNullOrEmpty(name), "O Nome é obrigatório ");
            DomainValidationsException.When(string.IsNullOrEmpty(document), "O documento é obrigatório");
            DomainValidationsException.When(string.IsNullOrEmpty(phone), "O celular é obrigatório");

            Name = name;
            Document = document;
            Phone = phone;
        }
    }
}
