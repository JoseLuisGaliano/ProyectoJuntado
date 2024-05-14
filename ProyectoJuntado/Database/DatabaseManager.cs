using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ProyectoJuntado.DataTypes;

namespace ProyectoJuntado.Database
{
    public static class DatabaseManager
    {
        private const string ConnectionString = @"Data Source=LAPTOP-85QOQ2U8;Initial Catalog=Lab5;Integrated Security=True;";

        // Events related queries
        public static List<ArtistModel> LoadArtists()
        {
            List<ArtistModel> artists = new List<ArtistModel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "SELECT ArtistID, Name FROM Artists";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute query and build list
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        artists.Add(new ArtistModel
                        {
                            ArtistID = (int)reader["ArtistID"],
                            Name = reader["Name"].ToString()
                        });
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading artists: {ex.Message}");
            }

            return artists;
        }

        public static List<EventModel> LoadArtistEvents(int artistId)
        {
            List<EventModel> events = new List<EventModel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = $"SELECT Name, Location, DateTime FROM Events WHERE ArtistID = {artistId}";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute query and build list
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        events.Add(new EventModel
                        {
                            Name = reader["Name"].ToString(),
                            Location = reader["Location"].ToString(),
                            DateTime = Convert.ToDateTime(reader["DateTime"])
                        });
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading events: {ex.Message}");
            }

            return events;
        }

        public static List<TicketType> GetTicketTypesForEvent(int eventId)
        {
            List<TicketType> ticketTypes = new List<TicketType>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "SELECT DISTINCT TicketType, Price FROM Tickets WHERE EventID = @EventID";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute query and build list
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string type = reader["TicketType"].ToString();
                        decimal price = (decimal)reader["Price"];
                        ticketTypes.Add(new TicketType(type, price));
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading ticket types: {ex.Message}");
            }

            return ticketTypes;
        }

        // Playlist/player related queries
        public static List<string> LoadPlaylist()
        {
            List<string> playlist = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "SELECT FilePath FROM SongFiles";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute query and build list
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string songPath = reader.GetString(reader.GetOrdinal("FilePath"));
                        playlist.Add(songPath);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading ticket types: {ex.Message}");
            }

            return playlist;
        }

        public static List<Playlist> LoadAllPlaylists()
        {
            List<Playlist> playlists = new List<Playlist>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "SELECT PlaylistID, Name, Description, CreationDate FROM Playlists";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute query and build list
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        playlists.Add(new Playlist
                        {
                            PlaylistID = Convert.ToInt32(reader["PlaylistID"]),
                            Name = reader["Name"].ToString(),
                            Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? string.Empty : reader["Description"].ToString(),
                            CreationDate = Convert.ToDateTime(reader["CreationDate"]),
                            IsLiked = false,  // Asumiendo estado inicial
                            IsFollowed = false// Asumiendo estado inicial
                        });
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading playlists: {ex.Message}");
            }

            return playlists;
        }

        public static List<Playlist> SearchPlaylists(string searchQuery)
        {
            List<Playlist> playlists = new List<Playlist>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "SELECT PlaylistID, Name, Description, CreationDate FROM Playlists WHERE LOWER(Name) LIKE @searchQuery";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchQuery", $"%{searchQuery}%");

                    // Execute query and build list
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        playlists.Add(new Playlist
                        {
                            PlaylistID = Convert.ToInt32(reader["PlaylistID"]),
                            Name = reader["Name"].ToString(),
                            Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? string.Empty : reader["Description"].ToString(),
                            CreationDate = Convert.ToDateTime(reader["CreationDate"]),
                            IsLiked = false,
                            IsFollowed = false
                        });
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading playlists: {ex.Message}");
            }

            return playlists;
        }

        public static bool DeletePlaylist(string name)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "DELETE FROM Playlists WHERE Name = @Name";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);

                    // Execute query
                    rowsAffected = command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while deleting a playlist: {ex.Message}");
            }

            return rowsAffected > 0;
        }

        public static bool InsertPlaylist(string name, string description)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "INSERT INTO Playlists (OwnerID, Name, Description, CreationDate) VALUES (@OwnerID, @Name, @Description, @CreationDate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OwnerID", 1); // 1 is an example owner
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@CreationDate", DateTime.Now);

                    // Execute query
                    rowsAffected = command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while adding a playlist: {ex.Message}");
            }

            return rowsAffected > 0;
        }

        public static List<Song> LoadPlaylistSongs(int playlistID)
        {
            List<Song> songs = new List<Song>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "SELECT s.Title, a.Name AS ArtistName FROM Songs s JOIN PlaylistSongs ps ON s.SongID = ps.SongID JOIN Artists a ON s.ArtistID = a.ArtistID WHERE ps.PlaylistID = @PlaylistID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PlaylistID", playlistID);

                    // Execute query and build list
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        songs.Add(new Song
                        {
                            SongTitle = reader["Title"].ToString(),
                            ArtistName = reader["ArtistName"].ToString()
                        });
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading songs: {ex.Message}");
            }

            return songs;
        }

        public static void InsertSongsIntoPlaylist(int playlistID, List<Song> songs)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Insert new songs into the playlist in the database
                    foreach (var song in songs)
                    {
                        string insertQuery = @"INSERT INTO PlaylistSongs (PlaylistID, SongID) 
                                               VALUES (@PlaylistID, (SELECT SongID FROM Songs WHERE Title = @SongTitle))";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@PlaylistID", playlistID);
                            insertCommand.Parameters.AddWithValue("@SongTitle", song.SongTitle);
                            insertCommand.ExecuteNonQuery();
                        }
                    }

                    connection.Close();
                }

                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static bool DeleteSongFromPlaylist(int playlistID, string songTitle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = @"DELETE FROM PlaylistSongs WHERE PlaylistID = @PlaylistID AND SongID = (SELECT SongID FROM Songs WHERE Title = @SongTitle)";
                    SqlCommand deleteCommand = new SqlCommand(query, connection);
                    deleteCommand.Parameters.AddWithValue("@PlaylistID", playlistID);
                    deleteCommand.Parameters.AddWithValue("@SongTitle", songTitle);

                    // Execute query
                    deleteCommand.ExecuteNonQuery();

                    connection.Close();
                }

                MessageBox.Show("Song removed successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing song: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        // Feedback related queries
        public static Song LoadSong(int songID)
        {
            Song loadedSong;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Build query
                    string query = @"
                    SELECT Songs.Title, Artists.Name, Albums.CoverArt
                    FROM Songs
                    INNER JOIN Artists ON Songs.ArtistID = Artists.ArtistID
                    INNER JOIN Albums ON Songs.AlbumID = Albums.AlbumID
                    WHERE Songs.SongID = @SongID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SongID", songID);

                    // Execute query
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Build Song object
                            loadedSong = new Song
                            {
                                SongTitle = reader.GetString(0),
                                ArtistName = reader.GetString(1),
                                CoverImage = reader.GetString(2)
                            };

                            return loadedSong;
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading song details: " + ex.Message);
                    return null;
                }
            }
        }

        public static List<string> LoadComments(int songID)
        {
            List<string> previousComments = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Build query
                    string query = "SELECT Comment, Username FROM Feedback INNER JOIN Users ON Feedback.UserID = Users.UserID WHERE SongID = @SongID ORDER BY DateAndTime DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SongID", songID);

                    // Execute command and build list
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string comment = reader.GetString(0);
                            string username = reader.GetString(1);
                            previousComments.Add(username + ": " + comment);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading previous comments: " + ex.Message);
                }
            }

            return previousComments;
        }

        public static bool InsertNewFeedback(int songID, int userRating, string comment)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Build query
                    string query = @"
                    INSERT INTO Feedback (UserID, SongID, Rating, Comment, DateAndTime)
                    VALUES (@UserID, @SongID, @Rating, @Comment, @DateAndTime)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", "SELECT UserID FROM Users");
                    command.Parameters.AddWithValue("@SongID", songID);
                    command.Parameters.AddWithValue("@Rating", userRating);
                    command.Parameters.AddWithValue("@Comment", comment);
                    command.Parameters.AddWithValue("@DateAndTime", DateTime.Now);

                    // Execute query
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Your feedback has been submitted successfully.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("It was not possible to submit your feedback.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting feedback: " + ex.Message);
                    return false;
                }
            }
        }

        // Sesion related queries
        public static bool SaveUser(string username, string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build query
                    string query = "INSERT INTO Users (Username, Email, Password, DateJoined, IsActive) VALUES (@Username, @Email, @Password, @DateJoined, @IsActive)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@DateJoined", DateTime.Now);
                    command.Parameters.AddWithValue("@IsActive", 1); // Usando 1 para true, asumiendo que la columna acepta valores enteros

                    // Execute query
                    command.ExecuteNonQuery();

                    connection.Close();
                    return true; // Retornar true si el usuario se guardó correctamente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario en la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButton.OK, MessageBoxImage.Error);
                return false; // Retornar false si ocurre un error
            }
        }

        public static bool VerifyUserLogin(string email, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Build SQL query
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute query
                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    // Verify user existence
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while selecting a value from the database: " + ex.Message);
                return false;
            }
        }
    }
}

