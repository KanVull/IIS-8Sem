using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = null;
            try
            {
                int MaxThreadsCount = Environment.ProcessorCount * 4;
                ThreadPool.SetMaxThreads(MaxThreadsCount, MaxThreadsCount);
                ThreadPool.SetMinThreads(2, 2);

                int counter = 0;
                Int32 port = 50000;
                IPAddress address = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(address, port);
                server.Start();

                Console.Write("Waiting for a connection...\n");
                while (true)
                {
                    ThreadPool.QueueUserWorkItem(ProcessQuery, server.AcceptTcpClient());
                    counter++;
                    Console.Write("Connection №" + counter.ToString() + " accepted\n");
                }
            }
            catch (SocketException e)
            {
                Console.Write("SocketException: {0}\n", e);
            }
            finally
            {
                server.Stop();
            }

            Console.Write("Press Enter to continue...");
            Console.Read();
        }

        static void ProcessQuery(object clientObject)
        {
            Byte[] bytes = new Byte[256];
            String data = null;
            Thread.Sleep(250);

            TcpClient client = clientObject as TcpClient;
            NetworkStream stream = client.GetStream();
            int i;
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                Console.Write("Received: {0}\n", data);
                data = data.ToUpper();
                Byte[] response = System.Text.Encoding.ASCII.GetBytes(data);
                stream.Write(response, 0, response.Length);
                Console.Write("Sent: {0}\n", data);
            }
            client.Close();
        }
    }
}
