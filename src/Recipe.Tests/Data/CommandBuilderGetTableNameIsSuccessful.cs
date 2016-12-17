using System;
using FluentAssertions;
using Microsoft.Extensions.Caching.Memory;
using Recipe.Server.Data;
using Recipe.Tests.Entities;
using Xunit;

namespace Recipe.Tests.Data
{
    [Trait("Command Builder","Name is successfully derived from the class")]
    public class CommandBuilderGetTableNameIsSuccessful
    {
        private ICommandBuilderService CommandBuilder { get; set; }
        private string TableName { get; set; }
        private string CorrectTableName { get; set; }

        private Exception Exception { get; set; }

        public CommandBuilderGetTableNameIsSuccessful()
        {
            try
            {
                CommandBuilder = new CommandBuilderService(new MemoryCache(new MemoryCacheOptions()));
                TableName = CommandBuilder.GetTableName<MyClass>();
                CorrectTableName = "myclasses";
            }
            catch (Exception ex)
            {
                Exception = ex;
            }

        }

        [Fact(DisplayName="Should not have thrown exception")]
        public void NoExceptions() => Exception.Should().BeNull();

        [Fact(DisplayName = "Tablename should not be null or empty")]
        public void TableNameIsntNullOrEmpty() => TableName.Should().NotBeNullOrEmpty();

        [Fact(DisplayName = "Tablename should be correct")]
        public void TableNameShouldBeCorrect()=> TableName.Should().BeEquivalentTo(CorrectTableName);
    }
}