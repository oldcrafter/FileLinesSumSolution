namespace FileLinesSum;

public class Token
{
    private string _token;

    public Token(string token)
    {
        _token = token.Replace(".", ","); ;
    } 

    public bool isNumber()
    {
        return double.TryParse(_token, out _);
    }

    public double ToNumber()
    {
        return double.Parse(_token);
    }
}
