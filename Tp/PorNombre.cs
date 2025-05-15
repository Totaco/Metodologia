using System;

namespace Tp
{
	public class PorNombre : IEstrategiaComparacion
	{
		public PorNombre(){}
		
		 public bool Igual(IComparable c, IComparable c2)
        {
        	return ((IAlumno)c).GetNombre().Length == ((IAlumno)c2).GetNombre().Length;
        }
        public  bool Menor(IComparable c, IComparable c2)
        {
            return ((IAlumno)c).GetNombre().Length < ((IAlumno)c2).GetNombre().Length;
        }
        public bool Mayor(IComparable c, IComparable c2)
        {
            return ((IAlumno)c).GetNombre().Length > ((IAlumno)c2).GetNombre().Length;
        }
	}
}
