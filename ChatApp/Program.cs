using System;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamChat = new TeamChatroom();
            
            var steve = new Developer("Steve");
            var justin = new Developer("Justin");
            var jenna = new Developer("Jenna");
            var kim = new Tester("Kim");
            var julia = new Tester("Julia");
            
            teamChat.RegisterMembers(steve, justin, jenna, kim, julia);
            
            steve.Send("Hey everyone, deploying at 2pm today");
            kim.Send("Roger that!");
            
            steve.SendTo<Developer>("Make sure to write your unit tests");
        }
    }
}