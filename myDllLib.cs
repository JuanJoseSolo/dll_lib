using System;
using System.Runtime.InteropServices;
// A namespace is using to import libraries into another .cs file.
namespace lib.app{
  // Public class TestApp 
  [ComVisible(true)]
  public class TestApp{
    public int TheValue;   
    // public method.
    public void SetValue(int theValue){
      System.Console.WriteLine("Using 'SetValue' method ...");
      TheValue = theValue;
    }
    public int GetValue(){
      System.Console.WriteLine("Using 'GetValue' method ...");
      return TheValue;
    }
  }
}
