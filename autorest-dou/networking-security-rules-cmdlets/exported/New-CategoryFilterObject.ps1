function New-CategoryFilterObject {
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='List of kinds associated with this filter.')]
    [string[]]
    ${KindList},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='A list of category key and list of values.')]
    [System.Collections.Generic.IDictionary[string,string]]
    ${Params},

    [Parameter(ParameterSetName='default', HelpMessage='The type of the filter being used.')]
    [string]
    ${Type})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-CategoryFilterObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-CategoryFilterObject
.ForwardHelpCategory Cmdlet

#>

}

