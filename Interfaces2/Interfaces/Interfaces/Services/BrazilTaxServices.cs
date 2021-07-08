namespace Interfaces.Services
{
    class BrazilTaxServices : ITaxService //BrazilTaxServices é um subtipo de ITaxService. Embora herde igual heranca, isso não
        //é uma heranca, isso é uma realização de interface
    {

        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
