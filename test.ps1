$secpasswd = ConvertTo-SecureString "Nutanix/1234" -AsPlainText -Force
$username = "admin"
$mycreds = New-Object System.Management.Automation.PSCredential ($username, $secpasswd)
$vms = Get-ServiceVm -Server 35.196.200.179 -Credential $mycreds -SkipSSL

foreach ($vm in $vms) {
    Write-Host ($vm.Spec | Format-Table | Out-String)
}

$vms = Get-ServiceVm -Server 35.196.200.179 -Username admin -Password "Nutanix/1234"  -SkipSSL

foreach ($vm in $vms) {
    Write-Host ($vm.Spec | Format-Table | Out-String)
}


$env:NutanixServer = "35.196.200.179"
$env:NutanixUsername = "admin"
$env:NutanixPassword = "Nutanix/1234"


$metadata = New-VmMetadataObject
$disk = New-DiskObject -DeviceType DISK -DiskSizeMib 200
$resources = New-VmResourcesObject -NumSockets 1 -NumVcpusPerSocket 2 -PowerState ON -MemorySizeMib 4096 -DiskList $disk
$spec = New-VmObject -ClusterReferenceUuid 27db5fb2-2aa0-48c4-bd2a-2fccdb8fad36 -Name test-cmdlets-2 -Resources $resources -Description desc

$vm = New-ServiceVm -Metadata $metadata -Spec $spec -SkipSSL

Write-Host ($vm.Metadata | Format-Table | Out-String)

$vmGet = Get-ServiceVm -Uuid $vm.Metadata.Uuid -SkipSSL

Write-Host ($vmGet.Metadata | Format-Table | Out-String)


$vms = Get-ServiceVm -SkipSSL

foreach ($vm in $vms) {
    Write-Host ($vm.Spec | Format-Table | Out-String)
}

Remove-ServiceVm -Uuid $vmGet.Metadata.Uuid -SkipSSl