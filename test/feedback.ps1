# Assume running from $TOP, so the DLL will be in build dir.
Import-Module ./build/NtnxPoshSDK.dll -force
$ClusterIp = '10.7.255.141'
$VmName = "__CreatedViaSDK__"
$Password = ConvertTo-SecureString 'Nutanix.123' -AsPlainText -Force
New-NTNX -Server $ClusterIp -UserName admin -Password $Password `
  -AcceptInvalidSslCerts

# New-VM example (see test/vm.ps1)
New-Vm -Cluster $Cluster -Name $VmName -ImageName $ImageName -NetworkName `
  $NetworkName

# How filter. Apparently some special case in FIQL syntax.
Get-Image -Name "cent.*"

# Batch delete example (TODO: on a real cluster)
Get-VM | % {$_.NumVcpusPerSocket = 55555555 } | Remove-Vm

# How Format-List works with JSON.
$Images = Get-Image
$Images | Format-List -Property @{Name = "Name"; Expression = {$_.json.spec.name} }
$Images | Select-Object -Property @{Name = "Name"; Expression = {$_.json.spec.name} }

# Get, internally set some variable, Set-Vm
Get-VM -Name $VmName | % { $_.json.spec.resources.power_state = "ON" } | Set-VM

# Opening a file in powershell doesn't work well. Might work on Windows. Not
# well in linux.
# I filed issue
# - https://github.com/PowerShell/PowerShell/issues/6395
Set-Json $Images[0].json


# Assert -- I couldn't find any for powershell.

# convert JSON to YAML
# - Waiting for native support in powershell:
#   ConvertFrom-Yaml, ConvertTo-Yaml
#   https://github.com/PowerShell/PowerShell/issues/3607



