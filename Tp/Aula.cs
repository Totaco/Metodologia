using System;

namespace Tp
{
	public class Aula
	{
		private Teacher teacher;
		
		public Aula(){}
		
		public void Comenzar(){
			Console.WriteLine("Comenzando la clase");
			teacher = new Teacher();
		}
		
		public void NuevoAlumno(IComparable a){
			teacher.goToClass(new AlumnoAdapter((IAlumno)a));
		}
		
		public void ClaseLista(){
			teacher.teachingAClass();
		}
	}
}
