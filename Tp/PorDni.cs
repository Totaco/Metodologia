using System;

namespace Tp
{
	public class PorDni : EstrategiaComparacion
	{
		public PorDni()
		{
		}
		
		public bool Igual(Comparable c, Comparable c2)
        {
        	return ((Alumno)c).GetDni == ((Alumno)c2).GetDni;
        }
        public  bool Menor(Comparable c, Comparable c2)
        {
            return ((Alumno)c).GetDni < ((Alumno)c2).GetDni;
        }
        public bool Mayor(Comparable c, Comparable c2)
        {
            return ((Alumno)c).GetDni > ((Alumno)c2).GetDni;
        }
	}
}
