using System;
using System.Net.Sockets;
using System.IO;

namespace PR5.client
{
	class Program
	{
        const int port = 8888;
        const string address = "127.0.0.1";
        static void Main()
		{
			Console.Title = "Client";
			Console.WriteLine("Rows:");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("Columns:");
			int m = int.Parse(Console.ReadLine());
			Console.WriteLine("Data Send");
			int [,] matrix1 = new int[n, m];
			int [,] result = new int[n, m];
			Random rnd = new Random();
			for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {

                    matrix1[i, j] = rnd.Next(50);        
                }
            TcpClient client = new TcpClient(address, port);
            NetworkStream stream = client.GetStream();
            
            using (var bw = new BinaryWriter(stream))
			using (var br = new BinaryReader(stream))
			{
				bw.Write(matrix1.GetLength(0));
                bw.Write(matrix1.GetLength(1));
              
                SendMatrix(bw, matrix1);
				ReceiveMatrix(br, result);
			}

			Console.WriteLine("Data Recieve:");
			Print(result);

			Console.ReadLine();
		}

		private static void SendMatrix(BinaryWriter bw, int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
				for (int j = 0; j < matrix.GetLength(1); j++)
					bw.Write(matrix[i, j]);
		}

		private static void ReceiveMatrix(BinaryReader br, int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
				for (int j = 0; j < matrix.GetLength(1); j++)
					matrix[i, j] = br.ReadInt32();
		}

		private static void Print(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
					Console.Write("{0}\t", matrix[i, j]);
				Console.WriteLine();
			}
		}
	}
}
