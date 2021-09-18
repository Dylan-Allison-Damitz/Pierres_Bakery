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
    }
}