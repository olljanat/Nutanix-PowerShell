function New-NewPet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${name},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${tag}
    )

    Process {
        'Creating object: Org.OpenAPITools.Model.NewPet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName Org.OpenAPITools.Model.NewPet -ArgumentList @(
            ${name},
            ${tag}
        )
    }
}
