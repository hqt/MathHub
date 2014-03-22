using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            TransData data = new TransData();
            data.Name = name;
            data.Age = 21;
            data.BirthDay = DateTime.Now;
            data.Message = message;

            string jsonData = JsonConvert.SerializeObject(data);

            Clients.All.broadcastMessage(name, jsonData);
            
        }
    }

    public class TransData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public string Message { get; set; }
    }
}