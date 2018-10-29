function New-Poll {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='Input for a task poll')]
    [Nutanix.Powershell.Models.ITaskPollInput]
    ${Body},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Username},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='The Password for authentication')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='The Password for authentication')]
    [securestring]
    ${Password},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='Skip the ssl validation')]
    [switch]
    ${SkipSSL},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='Skip the ssl validation')]
    [ValidateNotNull()]
    [pscredential]
    ${Credential},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Server},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Port},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidList', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Protocol},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', Mandatory=$true, HelpMessage='Poll timeout in seconds')]
    [int]
    ${PollTimeoutSeconds},

    [Parameter(ParameterSetName='PollPollTimeoutSecondsTaskUuidListExpanded', Mandatory=$true, HelpMessage='List of task UUIDs to poll on')]
    [string[]]
    ${TaskUuidList})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'PollPollTimeoutSecondsTaskUuidList' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-Poll_PollPollTimeoutSecondsTaskUuidList', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'PollPollTimeoutSecondsTaskUuidListExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-Poll_PollPollTimeoutSecondsTaskUuidListExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-Poll_PollPollTimeoutSecondsTaskUuidList', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-Poll_PollPollTimeoutSecondsTaskUuidList
.ForwardHelpCategory Cmdlet

#>

}

