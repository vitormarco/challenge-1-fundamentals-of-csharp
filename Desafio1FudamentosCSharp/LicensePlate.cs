namespace Desafio1FundamentosCSharp;
public class LicensePlate
{
    public required string PlateNumber { get; set; }


    public bool IsPlateNumberValid()
    {

        //Tem que verificar se possui 7 digitos
        if (PlateNumber?.Length != 7) return false;

        var isOnlyHaveAlphaNumeric = PlateNumber.All(char.IsLetterOrDigit);
        var areFirstThreeLetters = PlateNumber.Substring(0, 3).All(char.IsLetter);
        var areLastFourDigits = PlateNumber.Substring(PlateNumber.Length - 4).All(char.IsDigit);

        return isOnlyHaveAlphaNumeric && areFirstThreeLetters && areLastFourDigits;

    }
}
