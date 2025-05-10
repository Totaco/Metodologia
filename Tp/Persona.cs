using System;

namespace Tp
{
	abstract public class Persona : Comparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string n,int d)
		{
			nombre=n;
			dni=d;
		}
		
		public string GetNombre(){
			return nombre;
		}
		
		public int GetDni(){
			return dni;
		}
		
		public abstract bool SosIgual(Comparable c);
		
		public abstract bool SosMenor(Comparable c);
		
		public abstract bool SosMayor(Comparable c);
	}
}
