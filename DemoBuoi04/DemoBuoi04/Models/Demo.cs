namespace DemoBuoi04.Models
{
    public class Demo
    {
        public static int A()
        {
            Thread.Sleep(2000);
            return new Random().Next();
        }

        public static string B()
        {
            Thread.Sleep(5000);
            return "HCMUE-NET";
        }

        public static void C()
        {
            Thread.Sleep(3000);
        }
    }
}
