namespace Desafio1FudamentosCSharp;
public class Welcome
{
    public required string name { get; set; }
    public required string message { get; set; }

    public string WelcomeMessage()
    {
        string welcomeMessage = "Hello, {0}! {1}!";

        return string.Format(welcomeMessage, name, message);
    }
}
