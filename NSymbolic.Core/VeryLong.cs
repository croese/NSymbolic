namespace NSymbolic.Core
{
  public class VeryLong
  {
    private readonly string _value;
    private readonly bool _isNegative;
    
    //public static readonly VeryLong Zero = new VeryLong(0);

    public VeryLong(int i)
    {
      if (i < 0)
      {
        _isNegative = true;
        i = -i;
      }

      _value = i.ToString();
    }

    public VeryLong(string value = "0")
    {
      var s = value == "" ? "0" : value;
      _isNegative = s[0] == '-';
      _value = _isNegative ? s.Substring(1, s.Length - 1) : s;
    }

    public override string ToString()
    {
      var sign = (_isNegative ? "-" : "");
      var value = _value == "" ? "0" : _value;
      return $"{sign}{value}";
    }

    public static implicit operator string(VeryLong v)
    {
      return v.ToString();
    }
  }
}