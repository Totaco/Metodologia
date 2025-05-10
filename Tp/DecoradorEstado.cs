using System;

namespace Tp
{
	public class DecoradorEstado : DecoradorCalificacion
	{
		public DecoradorEstado(IAlumno a) : base(a) {}
		
		public override string MostrarCalificacion()
		{
			if(GetCalificacion()>=7){
				return ((IAlumno)alumno).MostrarCalificacion() + "(PROMOCIÓN)";
			}
			else{
				if(GetCalificacion()>3 && GetCalificacion()<7){
					return ((IAlumno)alumno).MostrarCalificacion() + "(APROBADO)";
				}
				else
					return ((IAlumno)alumno).MostrarCalificacion() + "(DESAPROBADO)";
			}
		}
	}
}
