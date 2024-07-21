class Circulo
{
   private double _radio;

   // expresión de cuerpo de método (expression-bodied member)
   public double Radio
   {
      get => _radio;
      set => _radio = value > 0 ? value : throw new ArgumentException("El radio no puede ser negativo");
   }

   public Circulo(double radio)
   {
      Radio = radio; // Usa el setter con validación
   }

   public double CalcularSuperficie()
   {
      return Math.PI * Math.Pow(Radio, 2);
   }
}