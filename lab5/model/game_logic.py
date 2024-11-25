from PyQt5.QtCore import QObject, pyqtSignal

class GameLogic(QObject):
    board_updated = pyqtSignal()  # Сигнал для обновления поля
    winner_declared = pyqtSignal(str)  # Сигнал для победителя

    def __init__(self, size=15):
        super().__init__()
        self.size = size
        self.board = [['' for _ in range(size)] for _ in range(size)]
        self.current_player = 'X'
        self.winner = None

    def make_move(self, row, col):
        if self.board[row][col] or self.winner:
            return False  # Ячейка занята или игра завершена

        self.board[row][col] = self.current_player
        if self.check_winner(row, col):
            self.winner = self.current_player
            self.winner_declared.emit(self.winner)
        else:
            self.current_player = 'O' if self.current_player == 'X' else 'X'

        self.board_updated.emit()
        return True

    def check_winner(self, row, col):
        directions = [(1, 0), (0, 1), (1, 1), (1, -1)]  # Горизонталь, вертикаль, диагонали
        for dx, dy in directions:
            count = 1
            for direction in (1, -1):  # Проверка в обе стороны
                x, y = row, col
                while True:
                    x += direction * dx
                    y += direction * dy
                    if 0 <= x < self.size and 0 <= y < self.size and self.board[x][y] == self.current_player:
                        count += 1
                    else:
                        break
            if count >= 5:
                return True
        return False
