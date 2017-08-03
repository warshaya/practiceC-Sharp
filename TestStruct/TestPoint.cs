class Test
{
   static void Main()
   {
      Point a = new Point( 10, 10 );
      Point b = a;
      a.x = 20;
      System.Console.WriteLine( b.x );
   }
}

