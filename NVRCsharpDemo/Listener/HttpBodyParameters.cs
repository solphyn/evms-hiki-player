using System;

namespace NVRCsharpDemo.Listener
{
    public class HttpBodyParameters
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public int Camera { get; set; }
        public DateTime Date { get; set; }
        public string Device { get; set; }
    }
}