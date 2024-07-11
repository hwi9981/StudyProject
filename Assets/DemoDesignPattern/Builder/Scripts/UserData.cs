namespace Builder
{
    public class UserData
    {
        public string id;
        public string userName;
        public int age;
        public GameData gameData;

        public UserData(string id, string userName, int age, GameData gameData)
        {
            this.id = id;
            this.userName = userName;
            this.age = age;
            this.gameData = gameData;
        }
    }
    public class GameData
    {
        public int currentLevel;
        public int highScore;

        public GameData()
        {
            currentLevel = 0;
            highScore = 0;
        }
    }
}

