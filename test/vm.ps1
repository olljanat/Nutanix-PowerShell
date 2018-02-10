#
# Exercise basic VM code paths.
#

# Assume running from $TOP, so the DLL will be in build.
Import-Module ./build/NtnxPoshSDK.dll

# TODO: pass in ClusterIp as arg to script.
$ClusterIp = "10.4.48.97"

#------------------------------------------------------------------------------
# DELETE paths.
#------------------------------------------------------------------------------

Remove-Vm -Uuid '2ca93e66-6b4c-4b21-a6bc-e991897bb90'

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

# Get all VMs.
Get-Vm

# Get VM using name.
Get-Vm -Name 'Vm-source07'

# Get VM using uuid.
Get-Vm -Uuid '2ca93e66-6b4c-4b21-a6bc-e991897bbe89'
