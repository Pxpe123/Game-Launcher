using System;
using System.Collections.Generic;
using System.IO;
using static System.Windows.Forms.AxHost;
using GameLauncher.Forms.PanelForms;

namespace GameLauncher.Systems.GamesFinder
{
    internal class CommonFinder
    {
        public static void FindGames(Action<List<Game>> callback)
        {
            // Define a list of common game directories to search for game executables
            List<string> gameDirectories = new List<string>
    {
        //@"D:\Games\A test",
        //@"D:\Games\ACE\Assetto Corsa Evoluzione",
        //C:\Program Files (x86)\Steam\steamapps\common",
        //@"C:\Program Files (x86)\Origin Games",
        //@"C:\Program Files\Epic Games"
    };
            // Define a list to store detected games
            List<Game> detectedGames = new List<Game>();

            // Iterate over each game directory and search for game executables
            foreach (string directory in gameDirectories)
            {
                if (Directory.Exists(directory))
                {
                    foreach (string file in Directory.GetFiles(directory, "*.exe", SearchOption.AllDirectories))
                    {
                        string gameName = Path.GetFileNameWithoutExtension(file);
                        string gameDirectory = Path.GetDirectoryName(file);

                        // Add the detected game to the list of detected games
                        detectedGames.Add(new Game { name = gameName, directory = gameDirectory });
                    }
                }
            }



            // Invoke the callback function to create buttons using the detected games
            callback(detectedGames);

            // Search for games in custom directories
            string customGameDirectoriesFile = "1231.dat";
            if (File.Exists(customGameDirectoriesFile))
            {
                List<string> customGameDirectories = File.ReadAllLines(customGameDirectoriesFile).ToList();
                foreach (string directory in customGameDirectories)
                {
                    if (Directory.Exists(directory))
                    {
                        foreach (string file in Directory.GetFiles(directory, "*.exe", SearchOption.AllDirectories))
                        {
                            string gameName = Path.GetFileNameWithoutExtension(file);
                            string gameDirectory = Path.GetDirectoryName(file);

                            // Add the detected game to the list of detected games
                            detectedGames.Add(new Game { name = gameName, directory = gameDirectory });
                        }
                    }
                }
            }

            callback(detectedGames);
        }

    }

    internal class Game
    {
        public string name;
        public string directory;
    }
}
