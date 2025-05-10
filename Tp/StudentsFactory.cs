using System;

namespace Tp
{
	public class StudentsFactory : FabricaDeAlumnos
	{
		public StudentsFactory(){}
		
		public override Comparable CrearAleatorio()
		{
			IAlumno alumno = new Alumno(generador.StringAleatorio(5),generador.NumeroAleatorio(99999999),generador.NumeroAleatorio(99999),generador.NumeroAleatorio(9)+1,generador.NumeroAleatorio(9)+1,new PorDni());
            IAlumno alumnoDecorado = new DecoradorLegajo(alumno);
            alumnoDecorado = new DecoradorLetras(alumnoDecorado);
            alumnoDecorado = new DecoradorEstado(alumnoDecorado);
            alumnoDecorado = new DecoradorRecuadro(alumnoDecorado);

            return alumnoDecorado;
		}
		
		public override Comparable CrearPorTeclado()
		{
			return new Alumno(lector.StringPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),lector.NumeroPorTeclado(),new PorDni());
		}
	}
}
