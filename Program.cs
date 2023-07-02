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
        int computerNumber;
        int playerNumber;

        Random rand = new Random();

        computerNumber = rand.Next(0, 10);

        string chosenDifficulty = DifficultyChoser();

        switch (chosenDifficulty)
        {
            case "Easy":
                computerNumber = rand.Next(0, 10);
                break;

            case "Medium":
                computerNumber = rand.Next(0, 25);
                break;

            case "Hard":
                computerNumber = rand.Next(0, 40);
                break;

            case "Very Hard":
                computerNumber = rand.Next(0, 75);
                break;

            case "Impossible":
                computerNumber = rand.Next(0, 100);
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

        Console.WriteLine("Wanna play again? [Y/N]: ");

        response = Console.ReadLine().ToUpper();

        if (response != "Y")
        {
            finalAnswer = false;
        }

        return finalAnswer;
    }
}

