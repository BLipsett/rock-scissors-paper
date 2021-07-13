using System;

namespace rock_paper_scissors
{
  class Game
    {
      private int _num = 0;
      private bool _playing = true;

      private int wins = 0;
      private int ties = 0;
      private int losses = 0;
      public void Start()
      {
       Console.WriteLine("Welcome to rock paper scissors");
        Console.WriteLine($"Wins{wins} Losses {losses} Ties{ties}");
        Console.WriteLine(@"
        Make Selection
        1 for rock
        2 for paper 
        3 for scissors");
        PlayGame();
      }
      public void PlayGame() 
      {

        while(_playing)
        {

        var r = new Random();
        _num = r.Next(1,4);
        

        

        string userInput = Console.ReadLine();
        Console.WriteLine($" you chose {userInput}");

        int userNum = 0;
        int.TryParse(userInput, out userNum);

        if (userInput == "q")
          {
              _playing = false;
              return;
          }

        if(userNum == _num)
        {
          Console.WriteLine("you tied idiot");
          ties++;
        }

        if(userNum > _num)
        {
          Console.WriteLine("You Win winner");
          wins++;
        }

        if(userNum < _num)
        {
          Console.WriteLine("You lose doodoo head");
          losses++;
        }
      Start();
        

          
        }
      }
    }
}

