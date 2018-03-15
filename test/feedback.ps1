

# How Format-List works with JSON.
$Images | Format-List -Property @{Name = "Name"; Expression = {$_.json.spec.name} }


