using System;

// This is the exception that VMware's PowerCLI throws on error.
public class VimException : Exception {
  public VimException():base() { }
  public VimException (string message): base(message) { }
}

public class NtnxException : Exception {
  public NtnxException():base() { }
  public NtnxException (string message): base(message) { }
}
