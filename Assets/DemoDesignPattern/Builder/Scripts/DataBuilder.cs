namespace Builder
{
    public class DataBuilder : IDataBuilder
    {
        public string id;
        public string userName;
        public int age;
        public GameData gameData;


        public DataBuilder SetUserName(string userName)
        {
            this.userName = userName;
            return this;
        }

        public DataBuilder SetUserID(string id)
        {
            this.id = id;
            return this;
        }

        public DataBuilder SetAge(int age)
        {
            this.age = age;
            return this;
        }

        public DataBuilder SetGameData(GameData data)
        {
            this.gameData = data;
            return this;
        }

        public UserData Build()
        {
            return new UserData(id, userName, age, gameData);
        }
    }
}