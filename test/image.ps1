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
echo "Get all Images..."
Get-Image
