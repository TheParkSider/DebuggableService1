$serviceName = "DebuggableService2"

Write-Host "Stopping Service..."
Stop-Service $serviceName -ErrorAction Ignore

Write-Host "Uninstalling Service..."
$null = sc.exe delete $serviceName

Start-Sleep -Second 3