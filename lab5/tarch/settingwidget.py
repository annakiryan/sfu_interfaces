from PyQt5.QtWidgets import QWidget, QVBoxLayout, QLabel, QLineEdit, QPushButton
from PyQt5.QtCore import Qt

class SettingWidget(QWidget):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Настройки")

        self.layout = QVBoxLayout(self)

        self.label = QLabel("Введите размер поля (от 10 до 20):", self)
        self.layout.addWidget(self.label)

        self.size_input = QLineEdit(self)
        self.layout.addWidget(self.size_input)

        self.save_button = QPushButton("Сохранить", self)
        self.layout.addWidget(self.save_button)

        self.save_button.clicked.connect(self.saveSettings)

    def saveSettings(self):
        size = self.size_input.text()
        if size.isdigit() and 10 <= int(size) <= 20:
            print(f"Размер поля: {size}")  # Здесь ты можешь сохранить размер в настройках игры
            self.close()
        else:
            print("Введите число от 10 до 20.")
