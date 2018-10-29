function Invoke-Image {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='Uuid', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='Uuid', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='Uuid', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='Uuid', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='Uuid', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='Uuid', HelpMessage='The Username for authentication')]
    [string]
    ${Username},

    [Parameter(ParameterSetName='Uuid', HelpMessage='The Password for authentication')]
    [securestring]
    ${Password},

    [Parameter(ParameterSetName='Uuid', HelpMessage='Skip the ssl validation')]
    [switch]
    ${SkipSSL},

    [Parameter(ParameterSetName='Uuid', HelpMessage='Skip the ssl validation')]
    [ValidateNotNull()]
    [pscredential]
    ${Credential},

    [Parameter(ParameterSetName='Uuid', HelpMessage='The Username for authentication')]
    [string]
    ${Server},

    [Parameter(ParameterSetName='Uuid', HelpMessage='The Username for authentication')]
    [string]
    ${Port},

    [Parameter(ParameterSetName='Uuid', HelpMessage='The Username for authentication')]
    [string]
    ${Protocol},

    [Parameter(ParameterSetName='Uuid', Mandatory=$true, HelpMessage='The UUID of the entity.')]
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Invoke-Image_Uuid', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Invoke-Image_Uuid
.ForwardHelpCategory Cmdlet

#>

}

