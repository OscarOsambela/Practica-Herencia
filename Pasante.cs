using System;

class Pasante:Empleado{
  public int HORASTRABAJO{get; set;}
  public int HORASESTUDIO{get; set;}

  public Pasante(int horasTrabajo, int horasEstudio, string nombre, string apellido, int salario):base(nombre, apellido,salario){
    this.HORASTRABAJO = horasTrabajo;
    this.HORASESTUDIO = horasEstudio;
  }
  public void Aprender(){
    Console.WriteLine("Soy {0} {1} estoy aprendiendo durante {2} horas.", NOMBRE, APELLIDO, HORASESTUDIO);
  }
  public override void Trabajar(){
    Console.WriteLine("Soy {0} {1} y trabajo {2} horas semanales.", NOMBRE, APELLIDO, HORASTRABAJO);
  }
}
