using System;

namespace Tp
{
	public class PorNombre : EstrategiaComparacion
	{
		public PorNombre()
		{
		}
		
		 public bool Igual(Comparable c, Comparable c2)
        {
        	return ((Alumno)c).GetNombre.Length == ((Alumno)c2).GetNombre.Length;
        }
        public  bool Menor(Comparable c, Comparable c2)
        {
            return ((Alumno)c).GetNombre.Length < ((Alumno)c2).GetNombre.Length;
        }
        public bool Mayor(Comparable c, Comparable c2)
        {
            return ((Alumno)c).GetNombre.Length > ((Alumno)c2).GetNombre.Length;
        }
	}
}
