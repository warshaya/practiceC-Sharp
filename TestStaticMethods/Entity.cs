public class Entity
{
   static int nextSerialNo;
   int serialNo;

   public Entity()
   {
      serialNo = nextSerialNo++;
   }

   public int GetSerialNo()
   {
      return serialNo;
   }

   public static int GetNextSerialNo()
   {
      return nextSerialNo;
   }

   public static void SetNextSerialNo( int value )
   {
      nextSerialNo = value;
   }
}
