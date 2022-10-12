using System.Text;

namespace DemoBuoi04.Models
{
    public class MyTool
    {
        public static string GenerateCode(int length = 5)
        {
            var sb = new StringBuilder();
            var rd = new Random();
            var pattern = @"qazwsxedcrfvtgbyhnujmiklop[]!@#$%^&*";
            for (int i = 0; i < length; i++)
            {
                sb.Append(pattern[rd.Next(pattern.Length)]);
            }
            return sb.ToString();
        }
    }
}
