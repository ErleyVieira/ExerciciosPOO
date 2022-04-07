Colecoes.Entities;

namespace Colecoes.Services;
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerDay, double pricePerHour){
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
        }

        public void ProcessInvoice(CarRental carRental){

        }

    }
