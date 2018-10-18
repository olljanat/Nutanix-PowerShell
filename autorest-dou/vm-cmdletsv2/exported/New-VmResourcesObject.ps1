function New-VmResourcesObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${DiskAddressAdapterType},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [int]
    ${DiskAddressDeviceIndex},

    [Parameter(ParameterSetName='default', HelpMessage='Disks attached to the VM.')]
    [Sample.API.Models.IVmDisk[]]
    ${DiskList},

    [Parameter(ParameterSetName='default', HelpMessage='GPUs attached to the VM.')]
    [Sample.API.Models.IVmGpu[]]
    ${GpuList},

    [Parameter(ParameterSetName='default', HelpMessage='VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2 (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloud_init should be provided. Note that guest customization can currently only be set during VM creation. Attempting to change it after creation will result in an error. Additional properties can be specified. For example - in the context of VM template creation if "override_script" is set to "True" then the deployer can upload their own custom script.')]
    [Sample.API.Models.IGuestCustomization]
    ${GuestCustomization},

    [Parameter(ParameterSetName='default', HelpMessage='Guest OS Identifier. For ESX, refer to VMware documentation link (https://www.vmware.com/support/developer/converter-sdk/conv43_apireference/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html) for the list of guest OS identifiers.')]
    [string]
    ${GuestOsId},

    [Parameter(ParameterSetName='default', HelpMessage='VM''s hardware clock timezone in IANA TZDB format (America/Los_Angeles).')]
    [string]
    ${HardwareClockTimezone},

    [Parameter(ParameterSetName='default', HelpMessage='Memory size in MiB.')]
    [int]
    ${MemorySizeMib},

    [Parameter(ParameterSetName='default', HelpMessage='NICs attached to the VM.')]
    [Sample.API.Models.IVmNic[]]
    ${NicList},

    [Parameter(ParameterSetName='default', HelpMessage='Number of vCPU sockets.')]
    [int]
    ${NumSockets},

    [Parameter(ParameterSetName='default', HelpMessage='Number of vCPUs per socket.')]
    [int]
    ${NumVcpusPerSocket},

    [Parameter(ParameterSetName='default', HelpMessage='Application names that are enabled.')]
    [string[]]
    ${NutanixGuestToolsSpecEnabledCapabilityList},

    [Parameter(ParameterSetName='default', HelpMessage='Desired mount state of Nutanix Guest Tools ISO.')]
    [string]
    ${NutanixGuestToolsSpecIsoMountState},

    [Parameter(ParameterSetName='default', HelpMessage='Nutanix Guest Tools is enabled or not.')]
    [string]
    ${NutanixGuestToolsSpecState},

    [Parameter(ParameterSetName='default', HelpMessage='The current or desired power state of the VM.')]
    [string]
    ${PowerState},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ReferenceKind},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ReferenceName},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ReferenceUuid},

    [Parameter(ParameterSetName='default', HelpMessage='Indicates whether VGA console should be enabled or not.')]
    [switch]
    ${VgaConsoleEnabled},

    [Parameter(ParameterSetName='default', HelpMessage='Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system will decide appropriate boot device order.')]
    [string[]]
    ${VmBootConfigBootDeviceOrderList},

    [Parameter(ParameterSetName='default', HelpMessage='MAC address of nic to boot from.')]
    [string]
    ${VmBootDeviceMacAddress},

    [Parameter(ParameterSetName='default', HelpMessage='Indicates whether to execute set script before ngt shutdown/reboot.')]
    [switch]
    ${VmGuestPowerStateTransitionConfigEnableScriptExec},

    [Parameter(ParameterSetName='default', HelpMessage='Indicates whether to abort ngt shutdown/reboot if script fails.')]
    [switch]
    ${VmGuestPowerStateTransitionConfigShouldFailOnScriptFailure},

    [Parameter(ParameterSetName='default', HelpMessage='Power state mechanism (ACPI/GUEST/HARD).')]
    [string]
    ${VmPowerStateMechanismMechanism},

    [Parameter(ParameterSetName='default', HelpMessage='Number of vNUMA nodes. 0 means vNUMA is disabled.')]
    [long]
    ${VmVnumaConfigNumVnumaNodes})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-VmResourcesObject', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process
{
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end
{
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
<#

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-VmResourcesObject
.ForwardHelpCategory Cmdlet

#>

}

