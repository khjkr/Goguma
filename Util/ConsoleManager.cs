using System;
using System.Collections.Generic;
using static System.Console;

namespace Goguma.Util
{
  class ConsoleManager
  {
    public static void PrintLogo()
    {
      Title = "GOGUMA MUD GAME";
      WriteColor(@"   __ _  ___   __ _ _   _ _ __ ___   __ _ 
  / _` |/ _ \ / _` | | | | '_ ` _ \ / _` |
 | (_| | (_) | (_| | |_| | | | | | | (_| |
  \__, |\___/ \__, |\__,_|_| |_| |_|\__,_|
   __/ |       __/ |                      
  |___/       |___/", ConsoleColor.Magenta);
      WriteLine();
    }

    public static void SetScreen(string Title)
    {
      Clear();
      PrintLogo();
      WriteColor(@"『 " + Title + " 』", ConsoleColor.Magenta);
    }

    public static void WriteColor(string msg, ConsoleColor fore)
    {
      ForegroundColor = fore;
      WriteLine(msg);
      ResetColor();
    }

    public static void Question(List<QuestionItem> questions)
    {
      Clear();
      PrintLogo();
      WriteLine("\n메뉴 항목을 선택해주세요.");

      for (int i = 0; i < questions.Count; i++)
      {
        WriteLine($"{i + 1}. {questions[i].Question}");
      }

      ConsoleKey key = ReadKey().Key;

      switch (key)
      {
        case ConsoleKey.D1:
          Execute(questions, 1, key);
          break;
        case ConsoleKey.D2:
          Execute(questions, 2, key);
          break;
        case ConsoleKey.D3:
          Execute(questions, 3, key);
          break;
        case ConsoleKey.D4:
          Execute(questions, 4, key);
          break;
        case ConsoleKey.D5:
          Execute(questions, 5, key);
          break;
        case ConsoleKey.D6:
          Execute(questions, 6, key);
          break;
        case ConsoleKey.D7:
          Execute(questions, 7, key);
          break;
        case ConsoleKey.D8:
          Execute(questions, 8, key);
          break;
        case ConsoleKey.D9:
          Execute(questions, 9, key);
          break;
        case ConsoleKey.D0:
          Execute(questions, 10, key);
          break;
        default:
          break;
      }
    }

    private static bool Execute(List<QuestionItem> questions, int index, ConsoleKey key)
    {
      if (questions.Count < index) return false;

      WriteLine();
      questions[index - 1].KeydownHandler(key);
      ReadKey();
      return true;
    }
  }
}