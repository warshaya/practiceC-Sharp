class Test
{
   static void Main()
   {
      Acme.Collections.Stack s = new Acme.Collections.Stack();
      s.Push( 1 );
      s.Push( 10 );
      s.Push( 100 );
      System.Console.WriteLine( s.Pop() );
      System.Console.WriteLine( s.Pop() );
      System.Console.WriteLine( s.Pop() );
   }
}
