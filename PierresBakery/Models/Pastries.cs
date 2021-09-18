namespace PierresBakery.Models
{
    public class Pastries 
    {
        public int PastriesCost { get; set; }
        public int PastriesAmount { get; set; }

        public Pastries(int pastriesCost, int pastriesAmount)
        {
            PastriesCost = pastriesCost;
            PastriesAmount = pastriesAmount;
        }

        public static int PastriesCalculator(int pastriesCost, int pastriesAmount) 
        {
            if (pastriesAmount <= 2)
            {
                return pastriesAmount * pastriesCost;
            }
            else
            {
                return 0;
            }
        }
    }
}