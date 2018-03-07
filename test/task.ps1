#
# Exercise basic Network code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll -force
$ClusterIp = "10.7.255.141"
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
New-NTNX -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

#------------------------------------------------------------------------------
# GET paths.
#------------------------------------------------------------------------------

Get-VM
Get-Task -Uuid '2b36507a-96de-4da2-9c77-2464696f1c86'
