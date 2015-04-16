using System;

namespace SimpleWebApp.ViewModels
{
    public class MessageView
    {
        public string Message { get; set; } 
        public DateTime When {get { return DateTime.Now; }}
    }
}