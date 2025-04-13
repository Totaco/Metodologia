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
		
		public string GetNombre{
			get{return nombre;}
		}
		
		public int GetDni{
			get{return dni;}
		}
		
		public abstract bool sosIgual(Comparable c);
		
		public abstract bool sosMenor(Comparable c);
		
		public abstract bool sosMayor(Comparable c);
	}
}
