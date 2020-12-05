using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    Empleado obj_empleado = new Empleado("Francisco", "Osambela", 3500);
    Empleado obj_empleado1 = new Empleado("Vernita", "Osambela", 3500);
		Jefe obj_jefe = new Jefe("Jeep", "Oscar", "Osambela", 8000);
    Pasante obj_pasante = new Pasante(20, 15, "Valentino", "Osambela", 1000);
    obj_empleado.Trabajar();
    obj_empleado1.Descansar();
    obj_jefe.Dirigir();
    obj_pasante.Aprender();
    obj_pasante.Trabajar();
  }
}