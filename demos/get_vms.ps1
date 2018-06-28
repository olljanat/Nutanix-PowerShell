Import-Module './src/Nutanix.PowerShell.SDK/bin/Debug/netcoreapp2.1/Nutanix.PowerShell.SDK.dll'
$pass = ConvertTo-SecureString -string "Utkala/4u" -force -AsPlainText
Connect-Cluster -Server 10.15.21.57 -UserName admin -Password $pass -AcceptInvalidSslCerts
Get-Cluster
echo "------"
Get-VM
