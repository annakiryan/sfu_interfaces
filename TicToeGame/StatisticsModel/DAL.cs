using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace StatisticsModel
{
    internal class DAL
    {
        private string connectionString;

        public DAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal (int totalGames, int totalXWins, int totalOWins, int totalOfDraws) GetStatistics()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT total_games, total_X_wins, total_O_wins, total_draws FROM game_statistics WHERE id = 1", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                totalGames: reader.GetInt32(0),
                                totalXWins: reader.GetInt32(1),
                                totalOWins: reader.GetInt32(2),
                                totalOfDraws: reader.GetInt32(3)
                            );
                        }
                        else
                        {
                            return (0, 0, 0, 0);
                        }
                    }
                }
            }
        }

        public void UpdateStatistics(int winner)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("UPDATE game_statistics SET total_games = total_games + 1, " +
                                         "total_X_wins = total_X_wins + @X_wins, " +
                                         "total_O_wins = total_O_wins + @O_wins, " +
                                         "total_draws = total_draws + @draws " +
                                         "WHERE id = 1", connection))
                {
                    int xWins = 0;
                    int oWins = 0;
                    int draws = 0;

                    // Если победил X
                    if (winner == 1)
                    {
                        xWins = 1;
                        oWins = 0;
                    }
                    // Если победил O
                    else if (winner == 2)
                    {
                        xWins = 0;
                        oWins = 1;
                    }
                    // Если ничья
                    else if (winner == 0)
                    {
                        draws = 1;
                    }

                    command.Parameters.AddWithValue("X_wins", xWins);
                    command.Parameters.AddWithValue("O_wins", oWins);
                    command.Parameters.AddWithValue("draws", draws);

                    command.ExecuteNonQuery();
                }

            }
        }
    }
}
