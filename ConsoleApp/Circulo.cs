class Circulo
{
   private double _radio;

   public double Radio
   {
      get { return _radio; }
      set
      {
         if (value >= 0)
            _radio = value;
         else
            throw new ArgumentException("El radio no puede ser negativo");
      }
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