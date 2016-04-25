namespace King.Azure.Unit.Test.Data
{
    using King.Azure.Data;
    using Xunit;

    public class AzureStorageResourcesTests
    {
        private readonly string ConnectionString = "UseDevelopmentStorage=true;";

        [Fact]
        public void Constructor()
        {
            new AzureStorageResources(ConnectionString);
        }

        [Fact]
        public void IsIAzureStorageResources()
        {
            //Assert.NotNull(new AzureStorageResources(ConnectionString) as IAzureStorageResources);
        }

        [Fact]
        public void IsAzureStorage()
        {
            //Assert.NotNull(new AzureStorageResources(ConnectionString) as AzureStorage);
        }
    }
}