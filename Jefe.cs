using System;

class Jefe:Empleado{
  public string AUTOEMPRESA{get;set;}

  public Jefe(string autoEmpresa, string nombre, string apellido, int salario):base(nombre, apellido, salario){
    this.AUTOEMPRESA = autoEmpresa;
  }

  public void Dirigir(){
    Console.WriteLine("Soy {0} {1} y tengo un {2} y mi salario es {3}.", NOMBRE, APELLIDO, AUTOEMPRESA, SALARIO);
  }
}
