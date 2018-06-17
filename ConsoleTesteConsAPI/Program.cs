using ConsoleTesteConsAPI.ControllerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleTesteConsAPI
{
	class Program
	{
		private static void Main(string[] args)
		{
			ClienteAPI clienteApi = new ClienteAPI();

			Console.WriteLine("Buscando api...");

			clienteApi.Pesquisar();

			Console.WriteLine("FIM api...");
			Console.ReadKey();
		}
	}
}
