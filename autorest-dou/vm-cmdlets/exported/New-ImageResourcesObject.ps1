function New-ImageResourcesObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Indicates the CPU architecture that the image is compatible with. If this is not specified for an image this will default to the CPU architecture type of the cluster.')]
    [string]
    ${Architecture},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The type of checksum calculated for the image')]
    [string]
    ${ChecksumChecksumAlgorithm},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ChecksumChecksumValue},

    [Parameter(ParameterSetName='default', HelpMessage='The type of image.')]
    [string]
    ${ImageType},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='Name of the producer/distribution of the image. For example windows or red hat.')]
    [string]
    ${ImageVersionResourcesProductName},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='Version string for the disk image.')]
    [string]
    ${ImageVersionResourcesProductVersion},

    [Parameter(ParameterSetName='default', HelpMessage='The source URI points at the location of a the source image which is used to create/update image.')]
    [string]
    ${SourceUri})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ImageResourcesObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-ImageResourcesObject
.ForwardHelpCategory Cmdlet

#>

}

