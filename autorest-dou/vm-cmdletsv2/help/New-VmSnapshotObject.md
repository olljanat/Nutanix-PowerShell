---
external help file: NutanixIntentfulAPI-help.xml
Module Name: NutanixIntentfulAPI
online version:
schema: 2.0.0
---

# New-VmSnapshotObject

## SYNOPSIS

## SYNTAX

```
New-VmSnapshotObject [-ExpirationTimeMsecs <Int32>] [-Name <String>]
 [-ReplicationTargetList <IVmSnapshotReplicationTargetListItemType[]>] [-SnapshotType <String>]
 [-VmSnapshotResourcesEntityUuid <String>] [<CommonParameters>]
```

## DESCRIPTION
{{Fill in the Description}}

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -ExpirationTimeMsecs
The time when this snapshot expires and will be garbage collected.If not set, then the snapshot never expires.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the snapshot

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReplicationTargetList
This describes a list replication targets where this snapshot existsor needs to be replicated to.
This is to support the replication andretrieve of the snapshot.

```yaml
Type: Sample.API.Models.IVmSnapshotReplicationTargetListItemType[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SnapshotType
Crash consistent or Application Consistent snapshot

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmSnapshotResourcesEntityUuid
UUID of the base entity for which snapshot need to be taken

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS
