$serviceName = "DebuggableService2"
$exe = Get-Item "DebuggableService2.exe"

Write-Host "Installing Service..."
New-Service -Name $serviceName -BinaryPathName $exe.FullName

Write-Host "Starting Service..."
Start-Service -Name $serviceName

Start-Sleep -Second 3