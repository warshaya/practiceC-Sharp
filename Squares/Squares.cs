class Squares
{
   static void Main()
   {
      int i = 0;
      int j;
      while ( i < 10 )
      {
         j = i * i;
	 System.Console.WriteLine( "{0} x {0} = {1}", i, j );
	 i = i + 1;
      }
   }
}
