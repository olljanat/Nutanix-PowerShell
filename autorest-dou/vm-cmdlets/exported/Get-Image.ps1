function Get-Image {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='All api calls that return a list will have this metadata block as input
')]
    [Nutanix.Powershell.Models.IImageListMetadata]
    ${GetEntitiesRequest},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='The Username for authentication')]
    [string]
    ${Username},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The Password for authentication')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The Password for authentication')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='The Password for authentication')]
    [securestring]
    ${Password},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='Skip the ssl validation')]
    [switch]
    ${SkipSSL},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='Skip the ssl validation')]
    [ValidateNotNull()]
    [pscredential]
    ${Credential},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='The Username for authentication')]
    [string]
    ${Server},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='The Username for authentication')]
    [string]
    ${Port},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrder', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImageUuidEtc', HelpMessage='The Username for authentication')]
    [string]
    ${Protocol},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The filter in FIQL syntax used for the results.')]
    [string]
    ${Filter},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The kind name')]
    [string]
    ${Kind},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The number of records to retrieve relative to the offset')]
    [int]
    ${Length},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='Offset from the start of the entity list')]
    [int]
    ${Offset},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The attribute to perform sort on')]
    [string]
    ${SortAttribute},

    [Parameter(ParameterSetName='ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', HelpMessage='The sort order in which results are returned')]
    [string]
    ${SortOrder},

    [Parameter(ParameterSetName='ImageUuidEtc', Mandatory=$true, HelpMessage='The UUID of the entity.')]
    [string]
    ${Uuid})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'ImagesFilterKindLengthOffsetSortAttributeSortOrder' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-Image_ImagesFilterKindLengthOffsetSortAttributeSortOrder', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ImageUuidEtc' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-Image_ImageUuidEtc', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-Image_ImagesFilterKindLengthOffsetSortAttributeSortOrderExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Get-Image_ImagesFilterKindLengthOffsetSortAttributeSortOrder', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Get-Image_ImagesFilterKindLengthOffsetSortAttributeSortOrder
.ForwardHelpCategory Cmdlet

#>

}

