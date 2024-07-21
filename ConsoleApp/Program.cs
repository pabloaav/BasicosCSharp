class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine("Calculadora de Superficie de Círculo");
      Console.Write("Ingrese el radio del círculo: ");

      if (double.TryParse(Console.ReadLine(), out double radio))
      {
         try
         {
            Circulo miCirculo = new Circulo(radio);
            double superficie = miCirculo.CalcularSuperficie();

            Console.WriteLine($"La superficie del círculo con radio {radio} es: {superficie:F2}");
         }
         catch (ArgumentException e)
         {
            Console.WriteLine($"Error: {e.Message}");
         }
      }
      else
      {
         Console.WriteLine("Error: Por favor ingrese un número válido para el radio.");
      }

      Console.WriteLine("Presione cualquier tecla para salir...");
      Console.ReadKey();
   }
}
