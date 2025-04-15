namespace Test_Unitaire_1_TestClasse;

public static class CustomAssert
{
    public static void AssertIsEven(int value, string message = "")
    {
        if (value % 2 != 0)
        {
            throw new AssertFailedException(
                string.IsNullOrWhiteSpace(message)
                    ? $"Expected {value} to be even, but it was not."
                    : message);
        }
    }
    public static void AssertIsToto(string value, string message = "")
    {
        if (!value.Equals("toto"))
        {
            throw new AssertFailedException(
                string.IsNullOrWhiteSpace(message)
                    ? $"Expected {value} to be 'toto', but it was not."
                    : message);
        }
    }
}