param(
    [Parameter(Mandatory=$true)]
    [string]$password = $( Read-Host )
)
[System.Environment]::SetEnvironmentVariable("BAES", $password, "User")
Write-Host "Admin Password successfully created\updated."