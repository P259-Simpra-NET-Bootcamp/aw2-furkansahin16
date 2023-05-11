namespace SimpraApi.Base;
public static class HelperMethods
{
    public static string NormalizeString(this string str)
    {
        str = str.ToLower().Trim();
        str = char.ToUpper(str[0]) + str.Substring(1);
        return str;
    }

    public static bool CheckIfOlderThan18(this DateTime date)
    {
        var today = DateTime.Today;
        var age = today.Year - date.Year;

        if (date.Date > today.AddYears(-age))
            age--;

        return age >= 18;
    }
}
