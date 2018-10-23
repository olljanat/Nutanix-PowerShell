---
external help file: NutanixIntentfulAPI-help.xml
Module Name: NutanixIntentfulAPI
online version:
schema: 2.0.0
---

# New-VmResourcesObject

## SYNOPSIS

## SYNTAX

```
New-VmResourcesObject [-DiskAddressAdapterType <String>] [-DiskAddressDeviceIndex <Int32>]
 [-DiskList <IVmDisk[]>] [-GpuList <IVmGpu[]>] [-GuestCustomization <IGuestCustomization>]
 [-GuestOsId <String>] [-HardwareClockTimezone <String>] [-MemorySizeMib <Int32>] [-NicList <IVmNic[]>]
 [-NumSockets <Int32>] [-NumVcpusPerSocket <Int32>] [-NutanixGuestToolsSpecEnabledCapabilityList <String[]>]
 [-NutanixGuestToolsSpecIsoMountState <String>] [-NutanixGuestToolsSpecState <String>] [-PowerState <String>]
 [-ReferenceKind <String>] [-ReferenceName <String>] [-ReferenceUuid <String>] [-VgaConsoleEnabled]
 [-VmBootConfigBootDeviceOrderList <String[]>] [-VmBootDeviceMacAddress <String>]
 [-VmGuestPowerStateTransitionConfigEnableScriptExec]
 [-VmGuestPowerStateTransitionConfigShouldFailOnScriptFailure] [-VmPowerStateMechanismMechanism <String>]
 [-VmVnumaConfigNumVnumaNodes <Int64>] [<CommonParameters>]
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

### -DiskAddressAdapterType
HELP MESSAGE MISSING

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

### -DiskAddressDeviceIndex
HELP MESSAGE MISSING

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

### -DiskList
Disks attached to the VM.

```yaml
Type: Sample.API.Models.IVmDisk[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GpuList
GPUs attached to the VM.

```yaml
Type: Sample.API.Models.IVmGpu[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GuestCustomization
VM guests may be customized at boot time using one of several different methods.
Currently, cloud-init w/ ConfigDriveV2 (for Linux VMs) and Sysprep (for Windows VMs) are supported.
Only ONE OF sysprep or cloud_init should be provided.
Note that guest customization can currently only be set during VM creation.
Attempting to change it after creation will result in an error.
Additional properties can be specified.
For example - in the context of VM template creation if "override_script" is set to "True" then the deployer can upload their own custom script.

```yaml
Type: Sample.API.Models.IGuestCustomization
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GuestOsId
Guest OS Identifier.
For ESX, refer to VMware documentation link (https://www.vmware.com/support/developer/converter-sdk/conv43_apireference/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html) for the list of guest OS identifiers.

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

### -HardwareClockTimezone
VM's hardware clock timezone in IANA TZDB format (America/Los_Angeles).

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

### -MemorySizeMib
Memory size in MiB.

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

### -NicList
NICs attached to the VM.

```yaml
Type: Sample.API.Models.IVmNic[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NumSockets
Number of vCPU sockets.

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

### -NumVcpusPerSocket
Number of vCPUs per socket.

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

### -NutanixGuestToolsSpecEnabledCapabilityList
Application names that are enabled.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NutanixGuestToolsSpecIsoMountState
Desired mount state of Nutanix Guest Tools ISO.

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

### -NutanixGuestToolsSpecState
Nutanix Guest Tools is enabled or not.

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

### -PowerState
The current or desired power state of the VM.

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

### -ReferenceKind
HELP MESSAGE MISSING

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

### -ReferenceName
HELP MESSAGE MISSING

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

### -ReferenceUuid
HELP MESSAGE MISSING

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

### -VgaConsoleEnabled
Indicates whether VGA console should be enabled or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmBootConfigBootDeviceOrderList
Indicates the order of device types in which VM should try to boot from.
If boot device order is not provided the system will decide appropriate boot device order.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmBootDeviceMacAddress
MAC address of nic to boot from.

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

### -VmGuestPowerStateTransitionConfigEnableScriptExec
Indicates whether to execute set script before ngt shutdown/reboot.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmGuestPowerStateTransitionConfigShouldFailOnScriptFailure
Indicates whether to abort ngt shutdown/reboot if script fails.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -VmPowerStateMechanismMechanism
Power state mechanism (ACPI/GUEST/HARD).

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

### -VmVnumaConfigNumVnumaNodes
Number of vNUMA nodes.
0 means vNUMA is disabled.

```yaml
Type: System.Int64
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

## NOTES

## RELATED LINKS
