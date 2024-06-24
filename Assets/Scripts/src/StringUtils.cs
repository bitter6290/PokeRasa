public static class StringUtils
{
    public static string LeadingZero2(this string input)
    {
        switch (input.Length)
        {
            case 1:
                return "00" + input;
            case 2:
                return "0" + input;
            default:
                return input;
        }
    }
    public static string LeadingZero4(this int input)
    {
        switch (input)
        {
            case < 10: return "000" + input;
            case < 100: return "00" + input;
            case < 1000: return "0" + input;
            default: return input.ToString();
        }
    }
    public static string LeadingZero1(this string input) => input.Length is 1 ? "0" + input : input;
}