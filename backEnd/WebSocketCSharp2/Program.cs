using ProtoBuf;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WebSocketSharp;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace WebSocketCM
{
    [ProtoContract]
    class Msg
    {
        [ProtoMember(1)]
        public int id { get; set; }
        [ProtoMember(2)]
        public int time_s { get; set; }
        [ProtoMember(3)]
        public string message { get; set; }
        [ProtoMember(4)]
        public string author { get; set; }
    }

    public class Laputa : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            //Msg newMsg;
            var msg = e.Data;
            //что пришло
            Console.WriteLine(msg);

            //Чтение строки байтов 
            /* using (var stream = new MemoryStream(Encoding.GetEncoding(1252).GetBytes(e.Data)))
             {
                 newMsg = Serializer.Deserialize<Msg>(stream);

             }
             Console.WriteLine(newMsg.message);
             */

            //var msg = newMsg.message;
            Send(msg);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var wssv = new WebSocketServer("ws://localhost:8181/");
            wssv.AddWebSocketService<Laputa>("/");
            Console.WriteLine("Listening...");
            wssv.Start();
            Console.ReadKey(true);
            wssv.Stop();
        }
    }
}
