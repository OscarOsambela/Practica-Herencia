using System;

interface IFunciones{
	void Profesion();
	void Empresa();
}

class Empleado: IFunciones{
  //propiedades
  public string NOMBRE{get;set;}
  public string APELLIDO{get;set;}
  public int SALARIO{get;set;}

  //constructor
  public Empleado(string nombre, string apellido, int salario){
    this.NOMBRE = nombre;
    this.APELLIDO = apellido;
    this.SALARIO = salario;
  }
  //metodos
  public virtual void Trabajar(){
    Console.WriteLine("Soy {0} {1} y estoy trabajando y mi salario es {2}.", NOMBRE, APELLIDO, SALARIO);
  }
  public void Descansar(){
    Console.WriteLine("Soy {0} {1} y estoy descansando.", NOMBRE, APELLIDO);
  }
	public void Profesion(){}
	public void Empresa(){}
}
