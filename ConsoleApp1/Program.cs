namespace EjemploList
{
   class Program
   {
      static void Main(string[] args)
      {
         // Crear una lista de enteros
         List<int> numeros = new List<int> { 1, 2, 3 };

         // Mostrar elementos iniciales
         Console.WriteLine("Elementos iniciales de la lista:");
         foreach (int numero in numeros)
         {
            Console.WriteLine(numero);
         }

         // Remover el elemento en la posición 2 (índice 1)
         numeros.RemoveAt(1);

         // Mostrar la lista después de eliminar el elemento
         Console.WriteLine("\nElementos de la lista después de eliminar el elemento en la posición 2:");
         foreach (int numero in numeros)
         {
            Console.WriteLine(numero);
         }

         // Intentar acceder al elemento eliminado
         try
         {
            int elemento = numeros[1];
            Console.WriteLine($"\nElemento en la posición 2: {elemento}");
         }
         catch (ArgumentOutOfRangeException ex)
         {
            Console.WriteLine("\nError: Intentaste acceder a un elemento que ha sido eliminado o está fuera de rango.");
         }
      }
   }
}
