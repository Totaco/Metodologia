using System;

namespace Tp
{
	public class AlumnoAdapter : Student
	{
		private IAlumno alumno;
		
		public AlumnoAdapter(IAlumno a)
		{
			alumno = a;
		}
		
		public string getName(){
			return alumno.GetNombre();
		}
		
		public int yourAnswerIs(int question){
			return alumno.ResponderPregunta(question);
		}
		
		public void setScore(int score){
			alumno.SetCalificacion(score);
		}
		
		public string showResult(){
			return alumno.MostrarCalificacion();
		}
		
		public bool equals(Student student){
			return (alumno.SosIgual(((Comparable)((AlumnoAdapter)student).alumno)));
		}
		
		public bool lessThan(Student student){
			return (alumno.SosMenor(((Comparable)((AlumnoAdapter)student).alumno)));
		}
		
		public bool greaterThan(Student student){
			return (alumno.SosMayor(((Comparable)((AlumnoAdapter)student).alumno)));
		}
	}
}
