#
# Exercise basic Network code paths.
#

# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll -force
$ClusterIp = '10.7.255.141'
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
New-NtnxConnection -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts
echo "The module has been automatically imported"
echo "You have been automatically connected to cluster 10.7.255.141"
echo "Try running this command: Get-VM"
echo "Or this command: Get-Help Get-VM"
echo ""
