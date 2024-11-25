from PyQt5.QtWidgets import QWidget, QPushButton, QGridLayout
from xogamewidget import XOGameWidget
from settingwidget import SettingWidget

class Menu(QWidget):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Главное меню")

        self.playButton = QPushButton("Играть")
        self.settingButton = QPushButton("Настройки")
        self.recordsButton = QPushButton("Статистика")

        layout = QGridLayout(self)
        layout.addWidget(self.playButton, 0, 0)
        layout.addWidget(self.settingButton, 1, 0)
        layout.addWidget(self.recordsButton, 2, 0)

        # Подключаем кнопки к обработчикам
        self.playButton.clicked.connect(self.playClicked)
        self.settingButton.clicked.connect(self.settingsClicked)
        self.recordsButton.clicked.connect(self.recordsClicked)

    def playClicked(self):
        self.gameWindow = XOGameWidget()  # Открываем окно игры
        self.gameWindow.show()

    def settingsClicked(self):
        self.settingsWindow = SettingWidget()  # Открываем окно настроек
        self.settingsWindow.show()

    def recordsClicked(self):
        # Статистика пока не реализована
        print("Статистика не реализована")
