using MyMessanger_Stepik;
using System;
using System.Collections.Generic;
using Terminal.Gui;

namespace ConsoleMessengerWithGUI
{
  class Program
  {
    // Очередь сообщений
    private static List<Message> messages = new List<Message>();
    private static MessangerClientAPI API = new MessangerClientAPI();

    private static MenuBar menu;
    private static Window winMain;
    private static Window winMessages;
    private static Label labelUser;
    private static TextField fieldUsername;
    private static Label labelMessage;
    private static TextField fieldMessage;
    private static Button btnSend;

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
