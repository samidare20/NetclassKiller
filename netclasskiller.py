#-*- coding: utf-8 -*-
import subprocess
import sys
from PyQt5.QtWidgets import *
from PyQt5.QtCore import *


class MyApp(QWidget):

    def __init__(self):
        super().__init__()
        self.layout=QVBoxLayout()
        self.initUI()
    def kill(self):
        target=['SvcNC80Cli.exe','NC80Cli.exe','rncHost.exe','NC80Cap.exe','SvcNC80Cli.exe']
        for i in target:
            subprocess.call('taskkill /F /IM '+i)
        message=QMessageBox.about(self,"result","Killing Netclass Complete!")
        
    def initUI(self):
        self.setWindowTitle('Netclass Killer')
        button=QPushButton("kill Netclass")
        button.clicked.connect(self.kill)
        self.resize(400,300)
        self.layout.addWidget(button)
        self.setLayout(self.layout)
        self.show()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = MyApp()
    sys.exit(app.exec_())