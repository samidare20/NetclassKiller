import subprocess
target=['SvcNC80Cli.exe','NC80Cli.exe','rncHost.exe','NC80Cap.exe','SvcNC80Cli.exe']
for i in target:
    #print("code:"+'taskkill /F /IM '+target[i])
    subprocess.call('taskkill /F /IM '+i)
