function New-NetworkSecurityRuleMetadataObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Categories for the network_security_rule')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${Categories},

    [Parameter(ParameterSetName='default', HelpMessage='UTC date and time in RFC-3339 format when network_security_rule was created')]
    [datetime]
    ${CreationTime},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${Kind},

    [Parameter(ParameterSetName='default', HelpMessage='UTC date and time in RFC-3339 format when network_security_rule was last updated')]
    [datetime]
    ${LastUpdateTime},

    [Parameter(ParameterSetName='default', HelpMessage='network_security_rule name')]
    [string]
    ${Name},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${ProjectReferenceKind},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ProjectReferenceName},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ProjectReferenceUuid},

    [Parameter(ParameterSetName='default', HelpMessage='Hash of the spec. This will be returned from server.')]
    [string]
    ${SpecHash},

    [Parameter(ParameterSetName='default', HelpMessage='Version number of the latest spec.')]
    [int]
    ${SpecVersion},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The kind name')]
    [string]
    ${UserReferenceKind},

    [Parameter(ParameterSetName='default', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${UserReferenceName},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${UserReferenceUuid},

    [Parameter(ParameterSetName='default', HelpMessage='network_security_rule uuid')]
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-NetworkSecurityRuleMetadataObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-NetworkSecurityRuleMetadataObject
.ForwardHelpCategory Cmdlet

#>

}

