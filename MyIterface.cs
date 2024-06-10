using System.Runtime.InteropServices;
// A namespace is using to import libraries into another .cs file.
namespace libApp{
  // Public class TestApp 
  [Guid("6fa2d1a2-77b9-4993-92db-28694b278838")]
  [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
  public interface ITestApp{
    // public method.
    public void SetValue(int theValue);
    public int GetValue();
  }
}
