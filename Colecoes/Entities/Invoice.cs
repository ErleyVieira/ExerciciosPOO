namespace Colecoes.Helper
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        
        public Invoice (double basicPayment, double tax){
            BasicPayment = basicPayment;
            Tax = tax;
        }
        
        public double TotalPayment { 
            get {
                return TotalPayment;
                }  
            set {
                TotalPayment = BasicPayment + Tax;
            }
            }

        public override string ToString()
        {
            return "Basic Payment: " + BasicPayment.ToString("F2") +
                    "Tax: " + Tax.ToString("F2") +
                    "Total Payment: " + TotalPayment.ToString("F2"); 
        }
    }
}