using System;

namespace ChatApp
{
    public abstract class TeamMember
    {
        public string Name { get; }
        public Chatroom Chatroom;

        public TeamMember(string name)
        {
            Name = name;
        }

        internal void SetChatroom(Chatroom chatroom)
        {
            Chatroom = chatroom;
        }

        public void Send(string message)
        {
            Chatroom.Send(Name, message);
        }

        public void SendTo<T>(string message) where T : TeamMember
        {
            Chatroom.SendTo<T>(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"from {from}: '{message}'");
        }
    }
}