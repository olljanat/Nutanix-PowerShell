#
# Exercise basic VM code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll
$ClusterIp = "10.4.48.97"
$TestVmName = "__CreatedViaSDK__"
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force

#------------------------------------------------------------------------------
# Test authenticatino
#------------------------------------------------------------------------------
New-NTNX -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

#------------------------------------------------------------------------------
# Create VM.
#------------------------------------------------------------------------------

echo "Creating VM..."
# TODO: get image uuid via /images REST
New-Vm -Name $TestVmName -ImageUuid '39ad7a2d-08f8-4bfa-976c-9f07ddfac672' `
  -NetworkUuid 'd3f69934-7d11-4347-8075-6048ce5425f9'
# TODO: wait using Task poll instead of sleep.
echo "Sleeping 15 seconds for VM to finish creating..."
Start-Sleep -Seconds 15

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

# Get all VMs.
echo "Get all VMs..."
Get-Vm

# Get VM using name.
echo "Get Test VM using name..."
$TestVm = Get-Vm -Name $TestVmName
echo "Got:"
$TestVm

# Get VM using uuid.
echo "Get Test VM using UUID..."
$TestVm = Get-Vm -Uuid $TestVm.Uuid

#------------------------------------------------------------------------------
# Start-Vm
#------------------------------------------------------------------------------

echo "Power on Test VM..."
Start-Vm -VM $TestVm
# TODO: wait using Task poll instead of sleep.
echo "Sleep 20 seconds for VM to power on..."
Start-Sleep -Seconds 20

#------------------------------------------------------------------------------
# DELETE paths.
#------------------------------------------------------------------------------

echo "Delete Test VM..."
Remove-Vm -Name $TestVmName
