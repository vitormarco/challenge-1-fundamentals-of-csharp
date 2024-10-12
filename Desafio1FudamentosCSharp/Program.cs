namespace Desafio1FudamentosCSharp;



class Program
{
    static void Main()
    {
        string exercise = "";
        List<AvailableOptions> availableOptions = new List<AvailableOptions>
        { 
            AvailableOptions.ExerciseOne,
            AvailableOptions.ExerciseTwo,
            AvailableOptions.ExerciseThree,
            AvailableOptions.ExerciseFour,
            AvailableOptions.Exit,
        };
        AvailableOptions selectedOption;


        while (
            (String.IsNullOrEmpty(exercise) || Enum.TryParse(exercise, out selectedOption) || !availableOptions.Contains(selectedOption))
            && !availableOptions.Equals(AvailableOptions.Exit))
        {
            Console.WriteLine("Which exercise would you like to execute?");
            foreach (var option in availableOptions)
            {
                if (option.Equals(AvailableOptions.Exit))
                {
                    Console.WriteLine($"{(int)option}. Exit");
                    continue;
                }
                Console.WriteLine($"{(int)option}. Exercise {(int)option}");
            }

            exercise = Console.ReadLine()?.Trim() ?? "";


            if (!Enum.TryParse(exercise, out selectedOption) || !availableOptions.Contains(selectedOption))
            {
                Console.WriteLine("Invalid Option, please try again.");
            }


            switch (selectedOption)
            {
                case AvailableOptions.ExerciseOne:
                    // Exercise one
                    string name = "";
                    while (String.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("What is your name?");
                        name = Console.ReadLine()?.Trim() ?? string.Empty;
                    }

                    string message = "";
                    while (String.IsNullOrEmpty(message))
                    {
                        Console.WriteLine("Enter a welcome message:");
                        message = Console.ReadLine()?.Trim() ?? string.Empty;
                    }


                    Welcome exerciseOne = new Welcome
                    {
                        name = name,
                        message = message
                    };

                    Console.WriteLine(exerciseOne.WelcomeMessage());
                    break;
                case AvailableOptions.ExerciseTwo:
                    User user = new User
                    {
                        name = "Vítor Adriano",
                        lastName = "Marco"
                    };

                    Console.WriteLine(user.FullName());
                    break;
                case AvailableOptions.ExerciseThree:
                    string firstInputValue = "";
                    double firstValue, secondValue;
                    while (!double.TryParse(firstInputValue, out firstValue))
                    {
                        Console.WriteLine("Please enter the first value:");
                        firstInputValue = Console.ReadLine()?.Trim() ?? string.Empty;
                        if (!double.TryParse(firstInputValue, out firstValue)) {
                            Console.WriteLine($"The value '{firstInputValue}' is invalid. Please enter a valid number.");
                        }
                    }

                    string secondInputValue = "";
                    while (!double.TryParse(secondInputValue, out secondValue))
                    {
                        Console.WriteLine("Please enter the second value:");
                        secondInputValue = Console.ReadLine()?.Trim() ?? string.Empty;

                        if (!double.TryParse(secondInputValue, out secondValue) || string.IsNullOrEmpty(secondInputValue)) {
                            Console.WriteLine($"The value '{secondInputValue}' is invalid. Please enter a valid number.");
                        }
                    }

                    Console.WriteLine
                    (
                        "The sum of these numbers is:" +
                        $"{MathOperationBetweenTwoNumbers.Sum(firstValue: firstValue, secondValue: secondValue)}"
                    );
                    Console.WriteLine
                    (
                        "The subtraction of these numbers is: " +
                        $"{MathOperationBetweenTwoNumbers.Subtract(firstValue: firstValue, secondValue: secondValue)}"
                    );
                    var divisionMessage = secondValue == 0 ? 
                        "It isn't possible to divide by zero." :
                        $"The division of these numbers is: {MathOperationBetweenTwoNumbers.Divide(firstValue: firstValue, secondValue: secondValue)}";
                    Console.WriteLine(divisionMessage);
                    Console.WriteLine
                    (
                        "The avarage of these numbers is: " +
                        $"{MathOperationBetweenTwoNumbers.Avarage(firstValue: firstValue, secondValue: secondValue)}");
                    break;
                case AvailableOptions.ExerciseFour:
                    Console.WriteLine("Enter one or more words");
                    var inputWords = Console.ReadLine()?.Trim() ?? string.Empty;
                    Console.WriteLine($"There is/are {WordsOperations.WordsLength(inputWords)} character(s) in this word/words");

                    break;
                case AvailableOptions.Exit:
                    Console.WriteLine("Finish the program...");
                    return;

            }
        }
    }
}