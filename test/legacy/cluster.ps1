#
# Exercise basic cluster code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll
$ClusterIp = "10.4.50.1"
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
New-NtnxConnection -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

$Clusters = Get-Cluster
$Clusters
