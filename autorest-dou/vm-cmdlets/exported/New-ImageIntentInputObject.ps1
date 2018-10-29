function New-ImageIntentInputObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ApiVersion},

    [Parameter(ParameterSetName='default', HelpMessage='A description for image.')]
    [string]
    ${ImageDescription},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='image Name.')]
    [string]
    ${ImageName},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='Describes the image spec resources object.')]
    [Nutanix.Powershell.Models.IImageResources]
    ${ImageResources},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The image kind metadata')]
    [Nutanix.Powershell.Models.IImageMetadata]
    ${Metadata})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ImageIntentInputObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-ImageIntentInputObject
.ForwardHelpCategory Cmdlet

#>

}

