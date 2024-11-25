from PyQt5.QtWidgets import QMainWindow, QGridLayout, QPushButton

class GameView(QMainWindow):
    def __init__(self, size, controller):
        super().__init__()
        self.size = size
        self.controller = controller

        self.setWindowTitle("Крестики-нолики 5 в ряд")
        self.grid_layout = QGridLayout()
        self.buttons = [[QPushButton() for _ in range(size)] for _ in range(size)]

        for i in range(size):
            for j in range(size):
                button = self.buttons[i][j]
                button.setFixedSize(40, 40)
                self.grid_layout.addWidget(button, i, j)
                button.clicked.connect(lambda _, row=i, col=j: self.controller.handle_move(row, col))

        self.setLayout(self.grid_layout)