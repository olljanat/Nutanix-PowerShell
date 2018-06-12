// Purpose: Exception classes source for 'Nutanix.PowerShell.SDK'
// Author: Nutanix
// Copyright: Nutanix, 2018
// Owner: PowerShell@nutanix.com
// Maintainer(s):
//   Jon Kohler  (Nutanix, JonKohler)
//   Alex Guo    (Nutanix, mallochine)

using System;

public class NtnxException : Exception
{
  public NtnxException(): base() { }
  public NtnxException(string message): base(message) { }
}
