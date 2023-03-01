namespace Eldorado.TeamManager.Web.Helpers
{
    public class EnumHelper
    {
        public static List<string> GetListEnum<T>()
        {
            List<string> enumList = Enum.GetValues(typeof(T)).Cast<string>().OrderBy(x =>x).ToList();

            return enumList;
        }
    }
}