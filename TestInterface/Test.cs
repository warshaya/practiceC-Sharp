class Test
{
   static void Main()
   {
      object obj = new EditBox();
      IControl control = (IControl)obj;
      IDataBound dataBound = (IDataBound)obj;
      System.Console.WriteLine(
         "{0}: object, {1}: IControl, {2}: IDataBound", obj, control, dataBound );
      IControl editBox = new EditBox();
      editBox.Paint();
   }
}
