using System.Reflection;

public interface IDataBound
{
   void Bind( Binder b );
}

public class EditBox: IControl, IDataBound
{
   void IControl.Paint()
   {}
   void IDataBound.Bind( Binder b )
   {}
}

