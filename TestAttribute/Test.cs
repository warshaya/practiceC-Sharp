using System;
using System.Reflection;

[Help("http://msdn.microsoft.com/")]
public class Widget
{
   [Help( "http://msdn.microsoft.com/", Topic = "Display" )]
   public void Display( string text )
   {
      System.Console.WriteLine( text );
   }
}

public class Test
{
   static void ShowHelp( MemberInfo member)
   {
      HelpAttribute a = Attribute.GetCustomAttribute( member, typeof(HelpAttribute)) as HelpAttribute;
      if (a == null)
      {
         Console.WriteLine( "No help for {0}", member);
      }
      else
      {
         Console.WriteLine("Help for {0}:", member);
         Console.WriteLine("  Url={0}, Topic={1}", a.Url, a.Topic);
      }
   }

   static void Main()
   {
      System.Console.WriteLine( "hello world");
      Widget wij = new Widget();
      wij.Display( "this string" );
      ShowHelp(typeof(Widget));
      ShowHelp(typeof(Widget).GetMethod("Display"));
//      wij.Display( wij.Topic );
   }
}

