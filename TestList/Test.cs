class Test
{
  public static void Main()
  {
    List<string> list1 = new List<string>();
    List<string> list2 = new List<string>( 10 );
    System.Console.WriteLine( "List 1 ->" + list1 + "<- " );
    System.Console.WriteLine( "List 2 ->" + list2 + "<- " );

    List<string> names = new List<string>();
    names.Capacity = 100;
    int i = names.Count;
    System.Console.WriteLine( "|-> int i is equal to {0}, count <-|", i );
    int j = names.Capacity;
    System.Console.WriteLine( "|-> int j is equal to {0}, capacity <-|", j );
  }
}
