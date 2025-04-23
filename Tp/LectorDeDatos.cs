using System;

namespace Tp
{
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public int NumeroPorTeclado(){
			Console.Write("Ingrese un numero: ");
			int num = int.Parse(Console.ReadLine());
			return num;
		}
		
		public string StringPorTeclado(){
			Console.Write("Ingrese un string: ");
			string str = Console.ReadLine();
			return str;
		}
	}
}
