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
        	return ((IAlumno)c).GetNombre().Length == ((IAlumno)c2).GetNombre().Length;
        }
        public  bool Menor(Comparable c, Comparable c2)
        {
            return ((IAlumno)c).GetNombre().Length < ((IAlumno)c2).GetNombre().Length;
        }
        public bool Mayor(Comparable c, Comparable c2)
        {
            return ((IAlumno)c).GetNombre().Length > ((IAlumno)c2).GetNombre().Length;
        }
	}
}
