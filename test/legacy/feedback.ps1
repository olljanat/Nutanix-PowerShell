# New-VM example (see test/vm.ps1)
New-Vm -Cluster $Cluster -Name $VmName -ImageName $ImageName -NetworkName `
  $NetworkName

# Batch delete example (TODO: on a real cluster)
Get-VM  -Name 'test-guo' | Remove-Vm

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

# ErrorAction: just use WriteError, and the powershell engine does everything
# else.


