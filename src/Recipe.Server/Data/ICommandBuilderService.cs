namespace Recipe.Server.Data
{
    public interface ICommandBuilderService
    {
        string BuildInsertAndReturnQuery<T>();
        string GetTableName<T>();
        string GetListOfColumns<T>(string prefix = "");
        string BuildSelectById<T>();
    }
}