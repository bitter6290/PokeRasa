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
}