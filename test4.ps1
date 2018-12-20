$credential = New-NutanixCredential -Username admin -Password Nutanix/1234 -ServerUri https://35.196.200.179:9440

$credential = New-CategoryKey -Name cmdletcategory -Description "created with a cmdlet" -Credential $credential -SkipSSL