namespace Eldorado.TeamManager.Web.Helpers
{
    public class EnumHelper
    {
        public static List<T> GetListEnum<T>()
        {
            List<T> enumList = Enum.GetValues(typeof(T)).Cast<T>().ToList();

            return enumList;
        }
    }
}