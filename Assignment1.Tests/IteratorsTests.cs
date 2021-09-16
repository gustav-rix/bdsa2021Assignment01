using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Return_Single_Stream_From_Multiple_Lists()
        {
            // Arrange
            int[] list1 = {1, 2, 3};
            int[] list2 = {4, 5, 6};
            int[] list3 = {7, 8, 9};
            int[][] items = {list1, list2, list3};
            var expected = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            // Act
            var actual = Iterators.Flatten(items);


            // Assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Find_Even_With_Filter()
        {
            // Arrange 
            int[] items = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var expected = new[] {2, 4, 6, 8};
            Predicate<int> even = Iterators.Even;
            // Act
            var actual = Iterators.Filter(items, even);
            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
