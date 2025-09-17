using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculadora;

public class Calculadora
 {
 
 public void Somar(double valor1, double valor2)
 {
  Console.WriteLine($"{valor1} + {valor2} =  {valor1 + valor2}");
 }   
 
 public void Subtrair(double valor1, double valor2)
 {
  Console.WriteLine($"{valor1} - {valor2} =  {valor1 - valor2}");
 }   
 
 public void Mutiplicar(double valor1, double valor2)
 {
  Console.WriteLine($"{valor1} * {valor2} =  {valor1 * valor2}");
 }   
 
 public void Dividir(double valor1, double valor2)
 {
  Console.WriteLine($"{valor1} / {valor2} =  {valor1 / valor2}");
 }  
 
 public void Potencia(double valor1, double valor2)
 {
  double potencia = Math.Pow(valor1, valor2);
  Console.WriteLine($"{valor1} ^ {valor2} = {potencia}");
 }  
 
 public void RaizQuadrada(double valor1)
 {
  double raizQuadrada = Math.Sqrt(valor1);
  Console.WriteLine($"Raiz quadrada de {valor1}  = {raizQuadrada}");
 }  
}