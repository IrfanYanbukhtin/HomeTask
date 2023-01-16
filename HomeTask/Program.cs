
namespace HomeTask_
{
    internal class Program
    {
       static void Main(string[] args)
        {
            #region TimeDifferenceTask

            var timeDifference = new TimeDifference();
            Console.Write("Starting time:");
            string time1 = Console.ReadLine();
            Console.Write("Finishing time:");
            string time2 = Console.ReadLine();
            string time3;
            var result = timeDifference.DifferenceTime(time1, time2, out time3);
            Console.WriteLine(result.ToString());

            #endregion

            #region CaesarTask

            //Console.WriteLine(Caesar.CaesarDecode(1, "Wooo"));

            #endregion

        }


    }
}