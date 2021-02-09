namespace MongoDbWebApi.Core
{
    public class BookstoreDbConfig
    {
        // tem q conger os mesmos definido no arquivo 'launchSettings.json'
        public string Database_Name { get; set; }
        public string Books_Collection_Name { get; set; }
        public string Connection_String { get; set; }
    }
}
