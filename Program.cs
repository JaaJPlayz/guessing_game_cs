public class Program
{
    public static void Main(String[] args)
    {
        bool continueResponse = true;

        while (true)
        {
            Game();
            continueResponse = continueVerifier();
            if (continueResponse == false)
            {
                break;
            }
        }

    }

    static void Game()
    {
        lineMaker(50);
        Console.WriteLine("Guessing Game");
        lineMaker(50);
        int computerNumber;
        int playerNumber;

        Random rand = new Random();

        computerNumber = rand.Next(0, 10);

        string chosenDifficulty = DifficultyChoser();

        switch (chosenDifficulty)
        {
            case "Easy":
                computerNumber = rand.Next(0, 10);
                Console.WriteLine("The computer chose a number between 0 and 10. Try to guess it!");
                break;

            case "Medium":
                computerNumber = rand.Next(0, 25);
                Console.WriteLine("The computer chose a number between 0 and 25. Try to guess it!");
                break;

            case "Hard":
                computerNumber = rand.Next(0, 40);
                Console.WriteLine("The computer chose a number between 0 and 40. Try to guess it!");
                break;

            case "Very Hard":
                computerNumber = rand.Next(0, 75);
                Console.WriteLine("The computer chose a number between 0 and 75. Try to guess it!");
                break;

            case "Impossible":
                computerNumber = rand.Next(0, 100);
                Console.WriteLine("The computer chose a number between 0 and 100. Try to guess it!");
                break;
        }
        Console.Write("Guess: ");
        playerNumber = Convert.ToInt32(Console.ReadLine());

        messageGenerator(computerNumber, playerNumber);
    }

    static string DifficultyChoser()
    {
        int chosenDifficulty = 0;
        String[] options = { "Easy", "Medium", "Hard", "Very Hard", "Impossible" };
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"[{i}] {options[i]}");
        }
        try
        {
            chosenDifficulty = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return options[chosenDifficulty];
    }

    static void messageGenerator(int x, int y)
    {
        if (x == y)
        {
            Console.WriteLine("Congrats! You win!");
        }
        else
        {
            Console.WriteLine($"Too bad, you lost!\nThe number was {x}.");
        }
    }

    static bool continueVerifier()
    {
        bool finalAnswer = true;
        string response = "N";

        Console.Write("Wanna play again? [Y/N]: ");

        response = Console.ReadLine().ToUpper();

        if (response != "Y")
        {
            finalAnswer = false;
        }

        lineMaker(50);
        return finalAnswer;
    }

    static void lineMaker(int lineLength)
    {
        for (int i = 0; i < lineLength; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
    }
}

