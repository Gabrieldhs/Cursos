using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;
namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);
        }
    }
}