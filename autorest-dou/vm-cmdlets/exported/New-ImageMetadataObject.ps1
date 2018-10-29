function New-ImageMetadataObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Categories for the image')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${Categories},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ProjectReferenceUuid},

    [Parameter(ParameterSetName='default', HelpMessage='Hash of the spec. This will be returned from server.')]
    [string]
    ${SpecHash},

    [Parameter(ParameterSetName='default', HelpMessage='Version number of the latest spec.')]
    [int]
    ${SpecVersion},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${UserReferenceUuid},

    [Parameter(ParameterSetName='default', HelpMessage='image uuid')]
    [string]
    ${Uuid})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ImageMetadataObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-ImageMetadataObject
.ForwardHelpCategory Cmdlet

#>

}

