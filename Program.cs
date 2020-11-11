using System;
using System.Collections.Generic;
using Goguma.Util;

namespace Goguma
{
  class Program
  {
    private static void GameInfo(ConsoleKey key)
    {
      ConsoleManager.SetScreen("게임 정보");
      Console.WriteLine("Name: Goguma");
      Console.WriteLine("Author: Hyunjun Kim");
      Console.WriteLine("Version: 0.01v");
      Console.WriteLine("ⓒ 2020 Hyunjun Kim");
    }

    private static void Terminate(ConsoleKey key)
    {
      Environment.Exit(0);
    }

    static void Main(string[] args)
    {

      while (true)
      {
        List<QuestionItem> questions = new List<QuestionItem>
        {
          new QuestionItem("게임 정보", GameInfo),
          new QuestionItem("게임 종료하기", Terminate)
        };

        ConsoleManager.Question(questions);
      }
    }
  }
}