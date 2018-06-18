// Copyright 2018 (c) Nutanix. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the repository root for full license information.
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
  public NtnxException(string message) : base(message)
  {
  }
}
