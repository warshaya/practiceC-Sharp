public class List<T>
{
   // Constant
  const int defaultCapacity = 4;
   // Fields
  T[] items;
  int count;

   // Constructors
  public List( int capacity = defaultCapacity )
  {
     items = new T[capacity];
  }

   // Properties
  public int Count
  {
     get { return count; }
  }

  public int Capacity
   {
      get { return items.Length; }
      set
      {
         if ( value < count ) value = count;
         if ( value != items.Length )
         {
	         T[] newItems = new T[value];
	         System.Array.Copy( items, 0, newItems, 0, count );
	         items = newItems;
         }
      }
   }

   // Indexer
   public T this[int index]
   {
      get
      {
         return items[index];
      }
      set
      {
         items[index] = value;
         OnChanged();
      }
   }

   // Methods
   public void Add( T item )
   {
      if ( count == Capacity ) Capacity = count * 2;
      items[count] = item;
      count++;
      OnChanged();
   }

   protected virtual void OnChanged()
   {
      if ( Changed != null ) Changed( this, System.EventArgs.Empty );
   }

   public override bool Equals( object other )
   {
      return Equals( this, other as List<T> );
   }

   static bool Equals( List<T> a, List<T> b )
   {
      if ( a == null ) return b == null;
      if ( b == null || a.count != b.count ) return false;
      for ( int i = 0; i < a.count; i++ )
      {
         if ( !object.Equals( a.items[i], b.items[i] ) )
         {
            return false;
         }
      }
      return true;
   }

   // Event
   public event System.EventHandler Changed;

   // Operators
   public static bool operator ==( List<T> a, List<T> b )
   {
      return Equals( a, b );
   }

   public static bool operator !=( List<T> a, List<T> b )
   {
      return !Equals( a, b );
   }
}

