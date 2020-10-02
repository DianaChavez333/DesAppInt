using System;

namespace p24Interfaz2
{
 public class Organismo{
     public void Respiracion () => Console.WriteLine("Respiracion");
     public void Movimiento () => Console.WriteLine("Movimiento");
     public void Crecimiento () => Console.WriteLine("Crecimiento");
 }
 public interface IAnimales{
     void Multicelular();
     void Sangrecaliente();
 }
 public interface ICanino: IAnimales{
     void Correr();
     void Cuatropatas();
 }
 public interface IPajaro: IAnimales{
     void Volar();
     void Dospatas();

 }
 public class Perro : Organismo, ICanino{
     public void Multicelular() => Console.WriteLine("Multicelular perro");
     public void Sangrecaliente() => Console.WriteLine("Sangrecaliente perro");
     public void Correr() => Console.WriteLine("Correr perro");
     public void Cuatropatas() => Console.WriteLine("Cuatropatas perro"); 
 }
 public class Perico: Organismo, IPajaro{
     public void Multicelular()=> Console.WriteLine("Multicelucal Perico");
     public void Sangrecaliente()=> Console.WriteLine("Sangrecaliente Perico");
     public void Volar()=> Console.WriteLine("Volar Perico");
     public void Dospatas()=> Console.WriteLine("Dospatas");
 }
 
 
 class Program
 {
     static void Main(string[]args)
     {
         Console.WriteLine("Segundo ejemplo de interface:");
         Perro miperro = new Perro();
         Console.WriteLine("caracteristicas de perro:");
         miperro.Respiracion();
         miperro.Movimiento();
         miperro.Crecimiento();
         miperro.Multicelular();
         miperro.Sangrecaliente();
         miperro.Correr();
         miperro.Cuatropatas();

         Perico miperico = new Perico();
         Console.WriteLine("\nCaracteristicas del Perico\n");
         miperico.Respiracion();
         miperico.Movimiento();
         miperico.Crecimiento();
    
     }
 }
 



}