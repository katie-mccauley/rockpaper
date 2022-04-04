
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
  static void Main(string[] args)
  {
    Random random = new Random();
    bool replay = true;
    String player;
    String computer;
    String startGame;
    Console.WriteLine("Do you want to play the game?");
    startGame = Console.ReadLine();
    startGame = startGame.ToUpper();
    if (startGame == "YES")
    {


      while (replay)
      {
        player = "";
        computer = "";
        Console.Write("Enter ROCK, PAPER OR SCISSORS!");
        player = Console.ReadLine();
        player = player.ToUpper();
        if (player == "ROCK" || player == "PAPER" || player == "SCISSORS")
        {

          var number = random.Next(1, 4);
          if (number == 1)
          {
            computer = "ROCK";
          }
          else if (number == 2)
          {
            computer = "PAPER";
          }
          else if (number == 3)
          {
            computer = "SCISSORS";
          }

          Console.WriteLine("Player: " + player);
          Console.WriteLine("Computer: " + computer);

          if (player == "ROCK" && computer == "ROCK")
          {
            Console.WriteLine("It is a draw!");
          }
          if (player == "ROCK" && computer == "PAPER")
          {
            Console.WriteLine("paper wins");
          }
          if (player == "ROCK" && computer == "SCISSORS")
          {
            Console.WriteLine("rock wins");
          }
          if (player == "SCISSORS" && computer == "SCISSORS")
          {
            Console.WriteLine("Its a tie");
          }
          if (player == "SCISSORS" && computer == "PAPER")
          {
            Console.WriteLine("Scissors wins the game");
          }
          if (player == "SCISSORS" && computer == "ROCK")
          {
            Console.WriteLine("rocks beats scisors");
          }
          if (player == "PAPER" && computer == "PAPER")
          {
            Console.WriteLine("it is a tie");
          }
          if (player == "PAPER" && computer == "ROCK")
          {
            Console.WriteLine("paper wins the gamee");
          }
          if (player == "PAPER" && computer == "SCISSORS")
          {
            Console.WriteLine("scirrosies wins the game");
          }
        };
        if (player == "QUIT")
        {
          Console.WriteLine("the game is over");
          return;
        }

      }
    }

    Console.ReadKey();
  }
}

