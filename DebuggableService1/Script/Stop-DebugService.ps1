$wh = [System.Threading.EventWaitHandle]::OpenExisting("StopService")
$wh.Set()