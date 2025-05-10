using System;

namespace Tp
{
	public class PorPromedio : EstrategiaComparacion
	{
		public PorPromedio()
		{
		}
		
        //Metodos de Comparable - comparar personas
        public bool Igual(Comparable c, Comparable c2)
        {
        	return ((IAlumno)c).GetPromedio() == ((IAlumno)c2).GetPromedio();
        }
        public  bool Menor(Comparable c, Comparable c2)
        {
            return ((IAlumno)c).GetPromedio() < ((IAlumno)c2).GetPromedio();
        }
        public bool Mayor(Comparable c, Comparable c2)
        {
            return ((IAlumno)c).GetPromedio() > ((IAlumno)c2).GetPromedio();
        }
    }
}
