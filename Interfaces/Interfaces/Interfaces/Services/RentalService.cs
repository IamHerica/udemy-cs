using System;
using Interfaces.Entities;
namespace Interfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //jeito não adequeado - dependecia forte entre os servicos de RentalService e BrazilTaxService 
        //se um dia quiser mudar o servico, teria que abrir o RentalService e alterar o servico que esta mudando
        //alem de mudar a implementação do novo servico.
        private BrazilTaxServices _brazilTaxService = new BrazilTaxServices(); //declarando o objeto e instanciando

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); //duracao da locacao

            double basicPayment = 0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); //Math.Ceiling é para arrendodar para cima(biblioteca do csharp)
            } else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }

    }
}
