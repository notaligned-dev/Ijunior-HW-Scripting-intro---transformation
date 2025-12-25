public static class UserUtilities
{
    private const float PercentToFloatConversion = 0.01f;

    public static float ConvertToFraction(this float percent) => percent * PercentToFloatConversion;
}