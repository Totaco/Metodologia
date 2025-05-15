using System;
using System.Collections.Generic;

namespace Tp
{
	public class Profesor : Persona, IObservado
	{
		private int antiguedad;
		private List<IObservador> observadores = new List<IObservador>();
		
		public Profesor(string n,int d, int a) : base(n,d)
		{
			this.antiguedad = a;
		}
		
		public void hablarALaClase(){
			Console.WriteLine("Hablando de algún tema");
			notificar("hablando");
		}
		
		public void escribirEnElPizarron(){
			Console.WriteLine("“Escribiendo en el pizarrón");
			notificar("escribiendo");
		}
		
		public int GetAntiguedad(){
			return antiguedad;
		}
		
		public override bool SosIgual(IComparable c){
			return ((Profesor)c).GetAntiguedad() == GetAntiguedad();
		}
		
		public override bool SosMenor(IComparable c){
			return ((Profesor)c).GetAntiguedad() > GetAntiguedad();
		}
		
		public override bool SosMayor(IComparable c){
			return ((Profesor)c).GetAntiguedad() < GetAntiguedad();
		}
		
		public override string ToString()
		{
			return "Profesor " + GetNombre() + ", Dni " + GetDni() + ", Años de antiguedad " + GetAntiguedad();
		}
		
		public void agregarObservador(IObservador o){
			observadores.Add(o);
		}
		
		public void notificar(string accion){
			foreach(IObservadorDeProfesores o in observadores)
				o.Actualizar(accion);
		}
	}
}
