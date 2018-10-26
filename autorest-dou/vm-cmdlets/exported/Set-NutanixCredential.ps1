function Set-NutanixCredential {
[CmdletBinding(DefaultParameterSetName='Credential')]
param(
    [Parameter(ParameterSetName='Credential', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [Nutanix.Powershell.Models.NutanixCredential]
    ${Credential},

    [Parameter(ParameterSetName='UsernamePasswordServerProtocolPortExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Server},

    [Parameter(ParameterSetName='UsernamePasswordServerProtocolPortExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Port},

    [Parameter(ParameterSetName='UsernamePasswordServerProtocolPortExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Protocol},

    [Parameter(ParameterSetName='UsernamePasswordServerProtocolPortExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Username},

    [Parameter(ParameterSetName='UsernamePasswordServerProtocolPortExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${Password})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'Credential' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-NutanixCredential_Credential', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'UsernamePasswordServerProtocolPortExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-NutanixCredential_UsernamePasswordServerProtocolPortExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-NutanixCredential_Credential', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Set-NutanixCredential_Credential
.ForwardHelpCategory Cmdlet

#>

}

