using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("Connection №" + i.ToString() + "\n");
                Connect("127.0.0.1", 50000, "Hello World!!!");
            }
            Console.Write("Press Enter to continue...");
            Console.Read();
        }

        static void Connect(String address, Int32 port, String query)
        {
            try
            {
                TcpClient client = new TcpClient(address, port);

                Byte[] data = System.Text.Encoding.ASCII.GetBytes(query);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                Console.Write("Sent: {0}\n", query);

                data = new Byte[256];
                String response = String.Empty;
                Int32 bytes = stream.Read(data, 0, data.Length);
                response = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.Write("Received: {0}\n", response);

                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.Write("ArgumentNullException: {0}\n", e);
            }
            catch (SocketException e)
            {
                Console.Write("SocketException: {0}\n", e);
            }
        }
    }
}
