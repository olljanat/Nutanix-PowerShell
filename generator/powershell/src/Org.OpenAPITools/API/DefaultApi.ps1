function Invoke-DefaultApiAddPet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [Org.OpenAPITools.Model.NewPet]
        ${newPet}
    )

    Process {
        'Calling method: DefaultApi-AddPet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:DefaultApi.AddPet(
            ${newPet}
        )
    }
}

function Invoke-DefaultApiDeletePet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [Int64]
        ${id}
    )

    Process {
        'Calling method: DefaultApi-DeletePet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:DefaultApi.DeletePet(
            ${id}
        )
    }
}

function Invoke-DefaultApiFindPetById {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [Int64]
        ${id}
    )

    Process {
        'Calling method: DefaultApi-FindPetById' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:DefaultApi.FindPetById(
            ${id}
        )
    }
}

function Invoke-DefaultApiFindPets {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String[]]
        ${tags},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Int32]
        ${limit}
    )

    Process {
        'Calling method: DefaultApi-FindPets' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:DefaultApi.FindPets(
            ${tags},
            ${limit}
        )
    }
}

