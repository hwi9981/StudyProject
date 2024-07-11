namespace Builder
{
    public interface IDataBuilder
    {
        DataBuilder SetUserName(string userName);
        DataBuilder SetUserID(string id);
        DataBuilder SetAge(int age);
        DataBuilder SetGameData(GameData data);
        UserData Build();
    }
}