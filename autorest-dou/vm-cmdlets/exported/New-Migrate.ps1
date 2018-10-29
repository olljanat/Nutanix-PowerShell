function New-Migrate {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='Specify the cluster and image(s) from the cluster to migrate to PC
')]
    [Nutanix.Powershell.Models.IImageMigrateInput]
    ${Body},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Username},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='The Password for authentication')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='The Password for authentication')]
    [securestring]
    ${Password},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='Skip the ssl validation')]
    [switch]
    ${SkipSSL},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='Skip the ssl validation')]
    [ValidateNotNull()]
    [pscredential]
    ${Credential},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Server},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Port},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceList', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Protocol},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ClusterReferenceUuid},

    [Parameter(ParameterSetName='MigrateClusterReferenceImageReferenceListExpanded', HelpMessage='Reference to the images from PE cluster to be migrated')]
    [Nutanix.Powershell.Models.IImageReference[]]
    ${ImageReferenceList})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'MigrateClusterReferenceImageReferenceList' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-Migrate_MigrateClusterReferenceImageReferenceList', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'MigrateClusterReferenceImageReferenceListExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-Migrate_MigrateClusterReferenceImageReferenceListExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\New-Migrate_MigrateClusterReferenceImageReferenceList', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\New-Migrate_MigrateClusterReferenceImageReferenceList
.ForwardHelpCategory Cmdlet

#>

}

