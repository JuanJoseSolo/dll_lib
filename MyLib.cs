using System.Runtime.InteropServices;

namespace libApp{
    [Guid("ace9381f-cc28-4860-84ba-34331b1b498e")]
    [ClassInterface(ClassInterfaceType.None)]
    public class MyComJLib : ITestApp{
      public int TheValue;
      public void SetValue(int theValue){
        TheValue = theValue + 10;
      }
      public int GetValue(){
        return TheValue;
      }
    }
}
