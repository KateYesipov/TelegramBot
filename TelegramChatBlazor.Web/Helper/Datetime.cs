namespace TelegramChatBlazor.Web.Helper
{
    public static class Datetime
    {
        public static DateTime? tempDate = null;
        public static string GetDateChat(DateTime dateTime)
        {
            if (tempDate?.Date == dateTime.Date)
            {
                return null;
            }

            tempDate = dateTime;

            if (dateTime.Date.Date == DateTime.Now.Date)
            {
                return "Today";
            }

            if (dateTime.Date.Date == DateTime.Now.AddDays(-1).Date)
            {
                return "Yesterday";
            }

            return dateTime.ToString($"MMM d") + $"th, {dateTime.Year}";
        }
    }
}
