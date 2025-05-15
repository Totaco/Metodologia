using System;

namespace Tp
{
	abstract public class Persona : IComparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string n,int d)
		{
			this.nombre = n;
			this.dni = d;
		}
		
		public string GetNombre(){
			return nombre;
		}
		
		public int GetDni(){
			return dni;
		}
		
		public abstract bool SosIgual(IComparable c);
		
		public abstract bool SosMenor(IComparable c);
		
		public abstract bool SosMayor(IComparable c);
	}
}
