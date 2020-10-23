using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(100);
            Not_Static_Server server = new Not_Static_Server();
            System.Console.WriteLine($"Client.Value = {client.get_value()}");
            System.Console.WriteLine($"Static_Server.Value = {client.get_value_thro_serv_static()}");
            System.Console.WriteLine($"Not_Static_Server.Value = {client.get_value_thro_serv(server)}");
        }
    }
    class Client
    {
        public Client(int a) 
        {
            value = a;
        } 
        private int value = 0;
        public int get_value() 
        {
           return value;
        }
        public int get_value_thro_serv_static() => Static_Server.get_value(this);
        public int get_value_thro_serv(Not_Static_Server server) => server.get_value(this);
    }
    static class Static_Server 
    {
        static public int get_value(Client a) => a.get_value();
    }
    class Not_Static_Server
    {
        public int get_value(Client a) => a.get_value();
    }
}