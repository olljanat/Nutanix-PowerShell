function New-NutanixCredential {
[CmdletBinding(DefaultParameterSetName='ServerUriUsernamePassword')]
param(
    [Parameter(ParameterSetName='ServerPortProtocolUsernameExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Server},

    [Parameter(ParameterSetName='ServerPortProtocolUsernameExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Port},

    [Parameter(ParameterSetName='ServerPortProtocolUsernameExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Protocol},

    [Parameter(ParameterSetName='ServerPortProtocolUsernameExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [Parameter(ParameterSetName='ServerUriUsernamePassword', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Username},

    [Parameter(ParameterSetName='ServerPortProtocolUsernameExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [Parameter(ParameterSetName='ServerUriUsernamePassword', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Password},

    [Parameter(ParameterSetName='ServerUriUsernamePassword', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ServerUri})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'ServerPortProtocolUsernameExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-NutanixCredential_ServerPortProtocolUsernameExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ServerUriUsernamePassword' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-NutanixCredential_ServerUriUsernamePassword', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-NutanixCredential_ServerUriUsernamePassword', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-NutanixCredential_ServerPortProtocolUsernameExpanded
.ForwardHelpCategory Cmdlet

#>

}

