using System;

public class NtnxException : Exception {
  public NtnxException():base() { }
  public NtnxException (string message): base(message) { }
}
