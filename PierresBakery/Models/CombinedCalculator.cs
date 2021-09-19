namespace PierresBakery.Models
{
    public class UserOrder 
    {
        public static int FinalOrder (int userBread, int userPastries)
        {
          return (userBread + userPastries);
        } 
    }
}