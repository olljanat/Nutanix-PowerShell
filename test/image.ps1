#
# Exercise basic Network code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll -force
$ClusterIp = '10.7.255.141'
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
New-NTNX -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

#------------------------------------------------------------------------------
# Test image variables.
#------------------------------------------------------------------------------
$image_name = 'centos73'
$image_url = 'http://earth.corp.nutanix.com/acro_images/automation/ahv_guest_os/DSK/centos73_vdisk.raw'

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

# Get all VMs.
echo "Get all Images..."
Get-Image

$image = Get-Image -Name $image_name
Get-Image -Uuid $image.Uuid

#------------------------------------------------------------------------------
# DELETE paths.
#------------------------------------------------------------------------------

Remove-Image -Uuid $image.Uuid

#------------------------------------------------------------------------------
# POST paths.
#------------------------------------------------------------------------------

New-Image -Name $image_name -URL $image_url -Description 'FROM SDK'
