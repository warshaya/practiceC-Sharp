class TestEvent
{
  static int changeCount;
  
  static void ListChanged( object sender, System.EventArgs e )
  {
    changeCount++;
  }

  static void Main()
  {
    List<string> names = new List<string>();
    names.Changed += new System.EventHandler( ListChanged );
    names.Add( "Liz" );
    names.Add( "Martha" );
    names.Add( "Beth" );
    System.Console.WriteLine( changeCount );
  }
}
