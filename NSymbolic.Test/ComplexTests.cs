using NSymbolic.Core;
using Xunit;

namespace NSymbolic.Test
{
  public class ComplexTests
  {
    [Fact]
    public void ComplexNumberCanBeCreated()
    {
      var c = new Complex<int>(3, 4);
      Assert.Equal(3, c.Real);
      Assert.Equal(4, c.Imaginary);
    }
  }
}