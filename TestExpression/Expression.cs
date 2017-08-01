public abstract class Expression
{
   public abstract double Evaluate( System.Collections.Hashtable vars );
}

public class Constant : Expression
{
   double value;

   public Constant( double value )
   {
      this.value = value;
   }

   public override double Evaluate( System.Collections.Hashtable vars )
   {
      return value;
   }
}

public class VariableReference : Expression
{
   string name;

   public VariableReference( string name )
   {
      this.name = name;
   }

   public override double Evaluate( System.Collections.Hashtable vars )
   {
      object value = vars[name];
      if ( value == null )
      {
         throw new System.Exception( "Unknown variable: " + name );
      }
      return System.Convert.ToDouble( value );
   }
}

public class Operation : Expression
{
   Expression left;
   char op;
   Expression right;

   public Operation( Expression left, char op, Expression right )
   {
      this.left = left;
      this.op = op;
      this.right = right;
   }

   public override double Evaluate( System.Collections.Hashtable vars )
   {
      double x = left.Evaluate( vars );
      double y = right.Evaluate( vars );
      switch ( op )
      {
         case '+' : return x + y;
	 case '-' : return x - y;
	 case '*' : return x * y;
	 case '/' : return x / y;
      }
      throw new System.Exception( "Unknown operator" );
   }
}
