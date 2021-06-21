// This file is initialized with a code version of this
// question's sample test case. Feel free to add, edit,
// or remove test cases in this file as you see fit!

using System;
using FluentAssertions;
using NUnit.Framework;

public class TwoNumberSumTest {

    [Test]
    public void Solution1TestCase1() {
        int[] output = TwoNumberSum.Solution1(new[] {3, 5, -4, 8, 11, 1, -1, 6}, 10);
        output.Should().BeEquivalentTo(new[] {-1, 11});
    }

    [Test]
    public void Solution1TestCase2() {
        int[] output = TwoNumberSum.Solution1(new[] {4, 6}, 10);
        output.Should().BeEquivalentTo(new[] {4, 6});
    }

    [Test]
    public void Solution1TestCase3() {
        int[] output = TwoNumberSum.Solution1(new[] {4, 6, 1}, 5);
        output.Should().BeEquivalentTo(new[] {4, 1});
    }

    [Test]
    public void Solution2TestCase1() {
        int[] output = TwoNumberSum.Solution2(new[] {3, 5, -4, 8, 11, 1, -1, 6}, 10);
        output.Should().BeEquivalentTo(new[] {-1, 11});
    }

    [Test]
    public void Solution2TestCase2() {
        int[] output = TwoNumberSum.Solution2(new[] {4, 6}, 10);
        output.Should().BeEquivalentTo(new[] {4, 6});
    }

    [Test]
    public void Solution2TestCase3() {
        int[] output = TwoNumberSum.Solution2(new[] {4, 6, 1}, 5);
        output.Should().BeEquivalentTo(new[] {4, 1});
    }

    [Test]
    public void Solution3TestCase1() {
        int[] output = TwoNumberSum.Solution3(new[] {3, 5, -4, 8, 11, 1, -1, 6}, 10);
        output.Should().BeEquivalentTo(new[] {-1, 11});
    }

    [Test]
    public void Solution3TestCase2() {
        int[] output = TwoNumberSum.Solution3(new[] {4, 6}, 10);
        output.Should().BeEquivalentTo(new[] {4, 6});
    }

    [Test]
    public void Solution3TestCase3() {
        int[] output = TwoNumberSum.Solution3(new[] {4, 6, 1}, 5);
        output.Should().BeEquivalentTo(new[] {4, 1});
    }
}