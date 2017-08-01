class Test
{
   static void Divide( int x, int y, out int result, out int remainder )
   {
      result = x / y;
      remainder = x % y;
   }

   static void Main()
   {
      int res, rem;
      Divide( 10, 3, out res, out rem );
      System.Console.WriteLine( "10 divided by 3 is {0} remainder {1}", res, rem );
   }
}
