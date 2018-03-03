#
# Exercise basic Network code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll -force
$ClusterIp = "10.4.50.1"
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
New-NTNX -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

# Get all VMs.
echo "Get all Images..."
Get-Image

Get-Image -Uuid 'ddf96624-438a-4d9c-94ec-823570224f69'

#------------------------------------------------------------------------------
# DELETE paths.
#------------------------------------------------------------------------------

Remove-Image -Uuid 'ddf96624-438a-4d9c-94ec-823570224f69'

#------------------------------------------------------------------------------
# POST paths.
#------------------------------------------------------------------------------

$image_url = 'http://earth.corp.nutanix.com/acro_images/automation/ahv_guest_os/DSK/centos73_vdisk.raw'
$image_name = 'centos73'
New-Image -Name $image_name -URL $image_url -Description 'FROM SDK'
