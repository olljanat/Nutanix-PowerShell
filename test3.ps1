$credential = New-NutanixCredential -Username admin -Password Nutanix/1234 -ServerUri https://35.196.200.179:9440

$resources = New-ImageResourcesObject -SourceUri http://archive.ubuntu.com/ubuntu/dists/bionic/main/installer-amd64/current/images/netboot/mini.iso
$imageObj = New-ImageObject -Name name -Description "Ubuntu mini iso" -Resources $resources
$metadata = New-ImageMetadataObject

$image = New-Image -Metadata $metadata -Spec $imageObj -Credential $credential -SkipSSL

$imageUploaded = New-Image -Metadata $metadata -ImageName "Uploaded image" -ImageDescription "Someimage" -Credential $credential -SkipSSL

Set-ImageFile -Uuid $imageUploaded.Metadata.Uuid -Path 'D:\mini.iso' -Credential $credential -SkipSSL