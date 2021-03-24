using System;
using Newtonsoft.Json;

namespace MyMessanger_Stepik
{
  class Program
  {
    static void Main(string[] args)
    {
      Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
      string output = JsonConvert.SerializeObject(msg);
      Console.WriteLine(output);
      Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
      Console.WriteLine(deserializedMsg);
      //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2021-03-24T18:04:47.8846682Z"}
      //RusAl < 24.03.2021 18:04:47 >: Privet

    }
  }
}
