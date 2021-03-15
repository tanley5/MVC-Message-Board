using System.Collections.Generic;

namespace MessageBoard.Models
{
    public static class Repository
    {
        private static List<Message> messages = new List<Message>();

        public static IEnumerable<Message> Messages => messages;

        public static void AddMessage(Message message)
        {
            messages.Add(message);
        }
    }
}