using System;
using System.Text;

namespace Tp
{
	public class GeneradorDeDatosAleatorios
	{
		private Random aleatorio = new Random();
		private const string caracteres = "abcdefghijklmnopqrstuvwxyz";
		
		public GeneradorDeDatosAleatorios()
		{
		}
		
		public int NumeroAleatorio(int max){
			return aleatorio.Next(0,max);
		}
		
		public string StringAleatorio(int cant){
			StringBuilder str = new StringBuilder(cant);
			for (int i = 0; i < cant; i++){
				str.Append(caracteres[aleatorio.Next(caracteres.Length)]);
			}
			return str.ToString();
		}
	}
}
