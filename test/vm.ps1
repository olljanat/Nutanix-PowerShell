#
# Exercise basic VM code paths.
#

# Assume running from $TOP, so the DLL will be in build.
Import-Module ./build/NtnxPoshSDK.dll

# TODO: pass in ClusterIp as arg to script.
# TODO: work out user/pass
$ClusterIp = "10.4.48.97"
$TestVmName = "__CreatedViaSDK__"

#------------------------------------------------------------------------------
# Create VM.
#------------------------------------------------------------------------------

New-Vm -Name $TestVmName -ImageUuid 'c4240283-62f6-40b5-ae78-82fd825bdeaa'
Start-Sleep -Seconds 5

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

# Get all VMs.
Get-Vm

# Get VM using name.
Get-Vm -Name $TestVmName

# Get VM using uuid.
Get-Vm -Uuid '2ca93e66-6b4c-4b21-a6bc-e991897bbe89'

#------------------------------------------------------------------------------
# SET paths.
#------------------------------------------------------------------------------

Set-Vm -Uuid '2ca93e66-6b4c-4b21-a6bc-e991897bb90'

#------------------------------------------------------------------------------
# DELETE paths.
#------------------------------------------------------------------------------

Remove-Vm -Uuid '2ca93e66-6b4c-4b21-a6bc-e991897bb90'
