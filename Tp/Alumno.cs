using System;

namespace Tp
{
	public class Alumno : Persona, IAlumno
	{
		private int legajo;
		private double promedio;
		private int calificacion;
		private IEstrategiaComparacion estrategia;
		
		public Alumno(string n, int d, int l, double p, int c) : base(n,d)
		{
			this.legajo = l;
			this.promedio = p;
			this.calificacion = c;
			this.estrategia = new PorDni();
		}
		
		public void SetCalificacion(int c){
			calificacion = c;
		}
		
		public int GetLegajo(){
			return legajo;
		}
		
		public double GetPromedio(){
			return promedio;
		}
		
		public int GetCalificacion(){
			return calificacion;
		}
		
		public override string ToString(){
			return "Alumno " + GetNombre() + ", Dni " + GetDni() + ", Legajo " + GetLegajo() + ", Promedio " + GetPromedio();
		}
		
		public override bool SosIgual(IComparable c){
			return estrategia.Igual(this,c);
		}
		
		public override bool SosMenor(IComparable c){
			return estrategia.Menor(this,c);
		}
		
		public override bool SosMayor(IComparable c){
			return estrategia.Mayor(this,c);
		}
		
		public void SetEstrategia(IEstrategiaComparacion es){
			estrategia = es;
		}
		
		public IEstrategiaComparacion GetEstrategia(){
			return estrategia;
		}
		
		public void PrestarAtencion(){
			Console.WriteLine("Prestando atención");
		}
		
		public void Distraerse(){
			GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
			int indice = generador.NumeroAleatorio(2);
			switch(indice){
				case 0:
					Console.WriteLine("Mirando el celular"); break;
				case 1:
					Console.WriteLine("Dibujando en el margen de la carpeta"); break;
				case 2:
					Console.WriteLine("Tirando aviones de papel"); break;
			}
		}
		
		public void Actualizar(string accion){
			switch (accion){
				case "hablando":
					PrestarAtencion(); break;
				case "escribiendo":
					Distraerse(); break;
			}
		}
		
		public virtual int ResponderPregunta(int pregunta){
			GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
			return gen.NumeroAleatorio(2) + 1;
		}
		
		public string MostrarCalificacion(){
			return GetNombre() + " " + GetCalificacion();
		}
	}
}
