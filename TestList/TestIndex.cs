class TestIndex
{
  public static void Main()
  {
    List<string> names = new List<string>();
    names.Add( "Liz" );
    names.Add( "Martha" );
    names.Add( "Beth" );
    for ( int i = 0; i < names.Count; i++ )
    {
      string s = names[i];
      System.Console.WriteLine( s );
      names[i] = s.ToUpper();
      System.Console.WriteLine( names[i] );
    }
  }
}
