using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace PR5
{
	class Program
	{

		static void Main()
		{
			Console.Title = "Server";
			var listener = new TcpListener(8888);
			listener.Start();
			Console.WriteLine("Подключение клиента...");

			TcpClient client = listener.AcceptTcpClient();
			NetworkStream stream = client.GetStream();
			using (var br = new BinaryReader(stream))
			using (var bw = new BinaryWriter(stream))
			{
				Console.WriteLine("Подключён! Ожидаю данные");
				int size1_m1 = br.ReadInt32();
                int size2_m1 = br.ReadInt32();
              
                int[,] matrix1 = new int[size1_m1, size2_m1];
           
				int[,] result = new int[size1_m1, size2_m1];
				ReceiveMatrix(br, matrix1);
				Console.WriteLine("Получена матрица: ");
				Print(matrix1);
				ReverseMatrix(matrix1, result);
				Console.WriteLine("Матрица заменена на противоположную");
				Console.WriteLine("Ответ отправлен!");
				SendMatrix(bw, result);
				Console.ReadLine();
			}
		}

         static void ReverseMatrix(int[,] a, int[,] result)
         {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result[i, j] = a[i,j] * -1;
                }
                
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
