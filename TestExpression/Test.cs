class Test
{
   public static void Main()
   {
      Expression e = new Operation( new VariableReference( "x" ),
      				'*', 
                            	new Operation( new VariableReference( "y" ),
						'+',
						new Constant( 2 ) ) );
      System.Collections.Hashtable vars = new System.Collections.Hashtable();
      vars["x"] = 3;
      vars["y"] = 5;
      System.Console.WriteLine( e.Evaluate( vars ) );
      vars["x"] = 1.5;
      vars["y"] = 9;
      System.Console.WriteLine( e.Evaluate( vars ) ); 
   }
}
