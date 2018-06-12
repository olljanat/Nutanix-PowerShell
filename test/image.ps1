#
# Exercise basic Network code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll -force
$ClusterIp = '10.7.255.141'
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
New-NtnxConnection -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

#------------------------------------------------------------------------------
# Test image variables.
#------------------------------------------------------------------------------
$ImageName = 'centos73'
$ImageName2 = 'centos73-sdk'
$ImageUrl = 'http://earth.corp.nutanix.com/acro_images/automation/ahv_guest_os/DSK/centos73_vdisk.raw'

#------------------------------------------------------------------------------
# POST paths.
#------------------------------------------------------------------------------

New-Image -Name $ImageName -URL $ImageUrl -Description 'FROM SDK'

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

# Get all VMs.
echo "Get all Images..."
Get-Image

$Image = Get-Image -Name $ImageName
Get-Image -Uuid $Image.Uuid

#------------------------------------------------------------------------------
# PUT paths.
#------------------------------------------------------------------------------

Set-Image -Image $Image -Name $ImageName2

#------------------------------------------------------------------------------
# DELETE paths.
#------------------------------------------------------------------------------

Remove-Image -Uuid $Image.Uuid
