function Set-Image {
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='An intentful representation of a image')]
    [Nutanix.Powershell.Models.IImageIntentInput]
    ${Body},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Username},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='The Password for authentication')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='The Password for authentication')]
    [securestring]
    ${Password},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='Skip the ssl validation')]
    [switch]
    ${SkipSSL},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='Skip the ssl validation')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='Skip the ssl validation')]
    [ValidateNotNull()]
    [pscredential]
    ${Credential},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Server},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Port},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', HelpMessage='The Username for authentication')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='The Username for authentication')]
    [string]
    ${Protocol},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpec', Mandatory=$true, HelpMessage='The UUID of the entity.')]
    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The UUID of the entity.')]
    [string]
    ${Uuid},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='HELP MESSAGE MISSING')]
    [string]
    ${ApiVersion},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', HelpMessage='A description for image.')]
    [string]
    ${ImageDescription},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='image Name.')]
    [string]
    ${ImageName},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='Describes the image spec resources object.')]
    [Nutanix.Powershell.Models.IImageResources]
    ${ImageResources},

    [Parameter(ParameterSetName='ImageUuidApiVersionMetadataSpecExpanded', Mandatory=$true, HelpMessage='The image kind metadata')]
    [Nutanix.Powershell.Models.IImageMetadata]
    ${Metadata})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'ImageUuidApiVersionMetadataSpec' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-Image_ImageUuidApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ImageUuidApiVersionMetadataSpecExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-Image_ImageUuidApiVersionMetadataSpecExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('NutanixIntentfulAPI.private\Set-Image_ImageUuidApiVersionMetadataSpec', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName NutanixIntentfulAPI.private\Set-Image_ImageUuidApiVersionMetadataSpec
.ForwardHelpCategory Cmdlet

#>

}

