using System;

namespace Tp
{
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string n, int d, int l, double p, int c):base(n,d,l,p,c){}
				
		public override int ResponderPregunta(int pregunta){
			return pregunta % 3;
		}
	}
}
