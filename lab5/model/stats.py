class GameStatistics:
    def __init__(self):
        self.wins = {'X': 0, 'O': 0}
        self.draws = 0

    def record_win(self, player):
        self.wins[player] += 1

    def record_draw(self):
        self.draws += 1

    def reset_statistics(self):
        self.wins = {'X': 0, 'O': 0}
        self.draws = 0
