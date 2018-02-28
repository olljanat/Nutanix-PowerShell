#
# Exercise basic Network code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll
$ClusterIp = "10.4.48.97"
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
New-NTNX -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

# Get all VMs.
echo "Get all Subnets..."
Get-VirtualSwitch

#------------------------------------------------------------------------------
# DELETE paths.
#------------------------------------------------------------------------------

Remove-VirtualSwitch -Uuid 'ddf96624-438a-4d9c-94ec-823570224f69'
