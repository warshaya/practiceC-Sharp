class Test
{
   static void Main()
   {
      Entity.SetNextSerialNo( 1000 );

      Entity e1 = new Entity();
      Entity e2 = new Entity();

      System.Console.WriteLine( e1.GetSerialNo() );
      System.Console.WriteLine( e2.GetSerialNo() );
      System.Console.WriteLine( Entity.GetNextSerialNo() );
   }
}
