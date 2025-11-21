using Xunit;
using System;
using System.Collections.Generic;

namespace Fujiq.Test.Exercises
{
    public class Day1BasicTests
    {
        [Fact]
        public void String_Concatenation_Should_Work()
        {
            string firstName = "John";
            string lastName = "Doe";
            string fullName = $"{firstName} {lastName}";
            Assert.Equal("John Doe", fullName);
        }

        [Fact]
        public void String_ToUpper_Should_ReturnUppercase()
        {
            string input = "hello";
            string result = input.ToUpper();
            Assert.Equal("HELLO", result);
        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(2, true)]
        [InlineData(4, true)]
        [InlineData(1, false)]
        [InlineData(3, false)]
        [InlineData(-2, true)]
        public void IsEven_Should_Return_Correct_Result(int number, bool expected)
        {
            var mathHelper = new MathHelper();
            var result = mathHelper.IsEven(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, 0)]
        [InlineData(-5, -3, -8)]
        public void Add_Should_Return_Correct_Sum(int a, int b, int expected)
        {
            var mathHelper = new MathHelper();
            var result = mathHelper.Add(a, b);
            Assert.Equal(expected, result);
        }
    }

    public class MathHelper
    {
        public bool IsEven(int number) => number % 2 == 0;
        public int Add(int a, int b) => a + b;
    }

    public class SimpleUserService
    {
        private readonly Dictionary<Guid, string> _users = new();
        public void AddUser(Guid id, string name) => _users[id] = name;
        public string? GetUser(Guid id) => _users.TryGetValue(id, out var name) ? name : null;
    }
}
