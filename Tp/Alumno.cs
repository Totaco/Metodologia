using System;

namespace Tp
{
	public class Alumno : Persona, IObservadorDeProfesores
	{
		private int legajo;
		private double promedio;
		private EstrategiaComparacion estrategia;
		
		public Alumno(string n, int d, int l, double p, EstrategiaComparacion e) : base(n,d)
		{
			legajo=l;
			promedio=p;
			estrategia=e;
		}
		
		public int GetLegajo{
			get{return legajo;}
		}
		
		public double GetPromedio{
			get{return promedio;}
		}
		
		public override string ToString(){
			return "Alumno " + GetNombre + ", Dni " + GetDni + ", Legajo " + GetLegajo + ", Promedio " + GetPromedio;
		}
		
		public override bool sosIgual(Comparable c){
			return estrategia.Igual(this,c);
		}
		
		public override bool sosMenor(Comparable c){
			return estrategia.Menor(this,c);
		}
		
		public override bool sosMayor(Comparable c){
			return estrategia.Mayor(this,c);
		}
		
		public void SetEstrategia(EstrategiaComparacion es){
			estrategia = es;
		}
		
		public EstrategiaComparacion GetEstrategia{
			get{return estrategia;}
		}
		
		public void prestarAtencion(){
			Console.WriteLine("Prestando atención");
		}
		
		public void distraerse(){
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
		
		public void actualizar(string accion){
			switch (accion){
				case "hablando":
					prestarAtencion(); break;
				case "escribiendo":
					distraerse(); break;
			}
		}
	}
}
