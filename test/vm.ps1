
# Assume running from $TOP, so the DLL will be in build.
Import-Module ./build/NtnxPoshSDK.dll

# TODO: pass in ClusterIp as arg to script.
$ClusterIp = "10.4.48.97"

#------------------------------------------------------------------------------
# Exercise basic VM code paths.
#------------------------------------------------------------------------------

# Get all VMs.
Get-VM

# Get VM with this name.
Get-VM -Name 'Vm-source07'
