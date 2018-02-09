
# Assume running from $TOP, so the DLL will be in build.
Import-Module ./build/NtnxPoshSDK.dll

# TODO: pass in ClusterIp as arg to script.
$ClusterIp = "10.4.48.97"

#------------------------------------------------------------------------------
# Exercise basic VM code paths.
#------------------------------------------------------------------------------

# Get all VMs.
Get-VM

# Get VM using name.
Get-VM -Name 'Vm-source07'

# Get VM using uuid.
Get-VM -Uuid '2ca93e66-6b4c-4b21-a6bc-e991897bbe89'
