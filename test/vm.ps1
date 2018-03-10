#
# Exercise basic VM code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll -force
$ClusterIp = '10.7.255.141'
$VmName = "__CreatedViaSDK__"
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
#------------------------------------------------------------------------------
# Test authentication
#------------------------------------------------------------------------------
New-NTNX -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

#------------------------------------------------------------------------------
# Create VM.
#------------------------------------------------------------------------------

$ImageName = 'centos73'
$NetworkName = 'VM Management Network'
$Clusters = Get-Cluster
$Cluster = $Clusters[0]

echo "Creating VM..."
New-Vm -Cluster $Cluster -Name $VmName -ImageName $ImageName -NetworkName `
  $NetworkName

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

# Get all VMs.
echo "Get all VMs..."
Get-Vm

# Get VM using name.
echo "Get Test VM using name..."
$TestVm = Get-Vm -Name $VmName
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
Remove-Vm -Name $VmName
