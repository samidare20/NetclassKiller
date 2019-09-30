import subprocess
from PyQt5 import *
target=['SvcNC80Cli.exe','NC80Cli.exe','rncHost.exe','NC80Cap.exe','SvcNC80Cli.exe']
for i in target:
    subprocess.call('taskkill /F /IM '+i)
