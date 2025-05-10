using System;
using System.Collections.Generic;

namespace Tp
{
	public class DecoradorLetras : DecoradorCalificacion
	{
		public DecoradorLetras(IAlumno a) : base(a) {}
		
		public override string MostrarCalificacion()
		{
			List<string> notaLetras = new List<string>{"Cero","Uno","Dos","Tres","Cuatro","Cinco","Seis","Siete","Ocho","Nueve","Diez"};
			return ((IAlumno)alumno).MostrarCalificacion() + "(" + notaLetras[GetCalificacion()] + ")";
		}
	}
}
