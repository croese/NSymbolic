using NSymbolic.Core;
using Xunit;

namespace NSymbolic.Test
{
  public class VeryLongTests
  {
    [Theory]
    [InlineData(42, "42")]
    [InlineData(-42, "-42")]
    public void VeryLongNumbersCanBeConvertedToAString(int n, string expected)
    {
      var i = new VeryLong(n);
      Assert.Equal(expected, i);
      Assert.Equal(expected, i.ToString());
    }
    
    [Theory]
    [InlineData("123")]
    [InlineData("-123")]
    public void VeryLongNumbersCanBeCreatedFromAString(string s)
    {
      var i = new VeryLong(s);
      Assert.Equal(s, i);
      Assert.Equal(s, i.ToString());
    }
  }
}