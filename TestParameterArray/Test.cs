class Test
{
   static void Main()
   {
      int x=1, y=2, z=3;
      System.Console.WriteLine( "x={0} y={1} z={2}", x, y, z );
      string s = "x={0} y={1} z={2}";
      object[] args = new object[3];
      args[0] = x;
      args[1] = y;
      args[2] = z;
      System.Console.WriteLine( s, args );
   }
}
