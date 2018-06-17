using ConsoleTesteConsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleTesteConsAPI.ControllerApi
{
	public class ClienteAPI
	{
		HttpClient client;
		dynamic resultado;

		public ClienteAPI()
		{
			
			client = new HttpClient
			{
				BaseAddress = new Uri("http://estoqueteste.somee.com/")
			};
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			
		}

		public void Pesquisar()
		{
			//chamando a api pela url
			HttpResponseMessage response = client.GetAsync("api/mercadoria").Result;

			//se retornar com sucesso busca os dados
			if (response.IsSuccessStatusCode)
			{
				//Serealizando o resultado
				var data = response.Content.ReadAsStringAsync().Result;

				//pegando o cabeçalho
				resultado = JsonConvert.DeserializeObject(data.ToString());
				
				//Exibindo o resultado deserializado
				Console.WriteLine("Exibindo usuarioRi " + resultado);
			}

			//Se der erro na chamada, mostra o status do código de erro.
			else
				Console.WriteLine(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
		}

	}
}
