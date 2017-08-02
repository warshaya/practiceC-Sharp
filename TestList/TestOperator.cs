class TestOperator
{
   public static void Main()
   {
      List<int> a = new List<int>();
//      a.Add( 1 );
//      a.Add( 2 );
      List<int> b = new List<int>();
//      b.Add( 1 );
//      b.Add( 2 );
      if ( a.Equals(b) ) 
      {
      System.Console.WriteLine( "works for null");
      }
//      System.Console.WriteLine( a == b );
//      b.Add( 3 );
//      System.Console.WriteLine( a == b );
   }
}

