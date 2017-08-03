class Test
{
   static void Main()
   {
      int[] a = new int[10];
      for ( int i=0; i < a.Length; i++)
      {
         a[i] = i * i;
      }
      for ( int i=0; i < a.Length; i++)
      {
         System.Console.WriteLine( "a[{0}] = {1}", i, a[i] );
      }

      // Multi-dimensional arrays
      int[] a1 = new int[10];
      int[,] a2 = new int[10, 5];
      int[,,] a3 = new int[10,5,2];

      // Array or arrays
      int[][] aa = new int[3][];
      aa[0] = new int[10];
      aa[1] = new int[5];
      aa[2] = new int[20];

      // Array initializer
      int[] aaa = new int[] {1, 2, 3};
      int[] aaaa = {1, 2, 3};
   }
}
