namespace DemoBuoi04.Models
{
    public static class MyExtension
    {
        /// <summary>
        /// Tính khoảng cách ngày
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end">Ngày cần đo</param>
        /// <returns>Số ngày</returns>
        public static int DemSoNgay(this DateTime start, DateTime end)
        {
            return Math.Abs((start - end).Days);
        }
    }
}
