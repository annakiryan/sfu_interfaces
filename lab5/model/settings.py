class GameSettings:
    def __init__(self):
        self.board_size = 15  # Размер поля
        self.starting_player = 'X'  # Кто ходит первым

    def update_settings(self, size, starting_player):
        self.board_size = size
        self.starting_player = starting_player
