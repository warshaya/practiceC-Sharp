enum Color
{
   Red = 1,
   Green = 2,
   Blue = 3
}

class Test
{
   static void PrintColor( Color color )
   {
      switch ( color )
      {
         case Color.Red:
            System.Console.WriteLine("Red");
            break;
         case Color.Green:
            System.Console.WriteLine("Green");
            break;
         case Color.Blue:
            System.Console.WriteLine("Blue");
            break;
         default:
            System.Console.WriteLine("Unknown color");
            break;
      }
   }
   
   static void Main()
   {
      Color c = Color.Red;
      PrintColor( c );
      PrintColor( Color.Blue );
      int i = (int) Color.Blue;
      System.Console.WriteLine( i );
      Color cc = (Color) 2;
      System.Console.WriteLine( cc );
      Color ccc = 0;
      System.Console.WriteLine( ccc );
      PrintColor( ccc );
   }
}
