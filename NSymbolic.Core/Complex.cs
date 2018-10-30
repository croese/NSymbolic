namespace NSymbolic.Core
{
  public class Complex<T>
  {
    public Complex(T real, T imaginary)
    {
      Real = real;
      Imaginary = imaginary;
    }

    public T Real { get; }
    public T Imaginary { get; }
  }
}