from PyQt5.QtWidgets import QWidget, QGridLayout, QPushButton
from PyQt5.QtCore import Qt

class XOGameWidget(QWidget):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Игра 'Крестики-Нолики'")

        self.m_currentPlayer = 'X'  # Игрок X начинает
        self.m_buttons = []

        layout = QGridLayout(self)

        # Создаём кнопки для игрового поля (3x3)
        for i in range(3):
            row = []
            for j in range(3):
                button = QPushButton("")
                button.setFixedSize(100, 100)
                button.setStyleSheet("font: 24px;")
                button.clicked.connect(self.onButtonClicked)
                layout.addWidget(button, i, j)
                row.append(button)
            self.m_buttons.append(row)

    def onButtonClicked(self):
        # Получаем нажатую кнопку
        button = self.sender()
        
        if button.text() == "":  # Если кнопка пустая
            button.setText(self.m_currentPlayer)  # Устанавливаем символ текущего игрока
            if self.checkWinner():
                print(f"Игрок {self.m_currentPlayer} выиграл!")
            self.m_currentPlayer = 'O' if self.m_currentPlayer == 'X' else 'X'  # Смена игрока

    def checkWinner(self):
        # Проверяем строки и столбцы
        for i in range(3):
            if self.m_buttons[i][0].text() == self.m_buttons[i][1].text() == self.m_buttons[i][2].text() != "":
                return True
            if self.m_buttons[0][i].text() == self.m_buttons[1][i].text() == self.m_buttons[2][i].text() != "":
                return True

        # Проверка диагоналей
        if self.m_buttons[0][0].text() == self.m_buttons[1][1].text() == self.m_buttons[2][2].text() != "":
            return True
        if self.m_buttons[0][2].text() == self.m_buttons[1][1].text() == self.m_buttons[2][0].text() != "":
            return True

        return False
