namespace PierresBakery.Models
{
    public class Bread 
    {
        public int BreadCost { get; set; }
        public int BreadAmount { get; set; }
        
        public Bread(int breadCost, int breadAmount)
        {
            BreadCost = breadCost;
            BreadAmount = breadAmount;
        }

        public static int BreadCalculator(int breadCost, int breadAmount) 
        {
            if (breadAmount >= 2)
            {
                int remainder = (breadAmount % 3);
                int noDeal = (remainder * breadCost);
                int orderBread = (breadAmount - remainder);
                int overallOrder = (((orderBread / 3) * 2) * breadCost);
                
                return (overallOrder + noDeal);
            }
            else 
            {
                return (breadAmount * breadCost);
            }
        }
    }   
}