class Test
{
   static void Swap( ref int x, ref int y )
   {
      int temp = x;
      x = y;
      y = temp;
   }

   static void Main()
   {
      int i = 1, j = 2;
      Swap( ref i, ref j );
      System.Console.WriteLine( "{0} {1}", i, j );
   }
}
