using System;

namespace Tp
{
	public class AlumnoProxy : IAlumno
	{
		private IAlumno alumno_real;
		protected int legajo;
        protected double promedio;
        protected IEstrategiaComparacion estrategia;
        protected int calificacion;
        protected string nombre;
        protected int dni;
		
		public AlumnoProxy(string n, int d, int l, double p, int c)
		{
			this.nombre = n;
            this.dni = d;
            this.legajo = l;
            this.promedio = p;
            this.calificacion = c;
            this.estrategia = new PorDni();
		}
		
		public string GetNombre(){
			return nombre;
		}
		
		public int GetLegajo(){
			return legajo;
		}
		
		public double GetPromedio(){
			return promedio;
		}
		
		public int GetDni(){
			return dni;
		}
		
        public int GetCalificacion(){
			return calificacion;
        }
		
		public virtual int ResponderPregunta(int pregunta){
			if(alumno_real == null){
				alumno_real = CrearAlumnoReal();
			}
			return alumno_real.ResponderPregunta(pregunta);
				
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
		
		public override string ToString(){
			return "Alumno " + GetNombre() + ", Dni " + GetDni() + ", Legajo " + GetLegajo() + ", Promedio " + GetPromedio();
		}
		
        public void SetEstrategia(IEstrategiaComparacion es){
			if(alumno_real != null)
				alumno_real.SetEstrategia(es);
			estrategia = es;
        }
		
        public IEstrategiaComparacion GetEstrategia(){
			return estrategia;
        }
		
        public void SetCalificacion(int c){
			if(alumno_real != null)
				alumno_real.SetCalificacion(c);
			calificacion = c;
        }
		
        public string MostrarCalificacion(){
			return GetNombre() + " " + GetCalificacion();
        }
		
		public bool SosIgual(IComparable c){
			return estrategia.Igual(this,c);
		}
		
		public bool SosMenor(IComparable c){
			return estrategia.Menor(this,c);
		}
		
		public bool SosMayor(IComparable c){
			return estrategia.Mayor(this,c);
		}
		
		public void Actualizar(string accion){
			switch (accion){
				case "hablando":
					PrestarAtencion(); break;
				case "escribiendo":
					Distraerse(); break;
			}
		}
		
		public virtual Alumno CrearAlumnoReal() 
        {
            Console.WriteLine("Creando Alumno real");
            return new Alumno(nombre, dni, legajo, promedio, calificacion); 
        }
	}
}
