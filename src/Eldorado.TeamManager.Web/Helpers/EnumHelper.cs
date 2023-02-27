namespace Eldorado.TeamManager.Web.Helpers
{
    public class EnumHelper
    {
        public static List<T> GetListEnum<T>()
        {
            List<T> enumList = Enum.GetValues(typeof(T)).Cast<T>().OrderBy(x =>x).ToList();

            return enumList;
        }
    }
}