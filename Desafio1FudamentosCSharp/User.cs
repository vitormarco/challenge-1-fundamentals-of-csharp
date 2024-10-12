namespace Desafio1FundamentosCSharp;
public class User
{
    public required string name { get; set; }
    public required string lastName { get; set; }

    public string FullName()
    {
        return $"{name} {lastName}";
    }
}
