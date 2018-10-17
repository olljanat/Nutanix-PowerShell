function New-ServiceVm {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='VmApiVersionMetadataSpec', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='An intentful representation of a vm')]
    [Sample.API.Models.IVmIntentInput]
    ${Body},

    [Parameter(ParameterSetName='VmApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='VmApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='VmApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='VmApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='VmApiVersionMetadataSpec', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='VmApiVersionMetadataSpecExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='VmApiVersionMetadataSpec', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='VmApiVersionMetadataSpecExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='VmApiVersionMetadataSpec', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='VmApiVersionMetadataSpecExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='VmApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ApiVersion},

    [Parameter(ParameterSetName='VmApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The vm kind metadata')]
    [Sample.API.Models.IVmMetadata]
    ${Metadata},

    [Parameter(ParameterSetName='VmApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='An intentful representation of a vm spec')]
    [Sample.API.Models.IVm]
    ${Spec})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'VmApiVersionMetadataSpecExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ServiceVm_VmApiVersionMetadataSpecExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'VmApiVersionMetadataSpec' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ServiceVm_VmApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  default {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-ServiceVm_VmApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-ServiceVm_VmApiVersionMetadataSpec
.ForwardHelpCategory Cmdlet

#>

}

