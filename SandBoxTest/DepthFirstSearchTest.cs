namespace AlgoExpertTest
{
    using System.Collections.Generic;
    using AlgoExpert;
    using FluentAssertions;
    using NUnit.Framework;
    using Node = AlgoExpert.DepthFirstSearch.Node;

    public class DepthFirstSearchTest
    {
        [Test]
        public void TestCase1()
        {
            Node tree = new Node("A")
            {
                children = new List<Node>
                {
                    new Node("B")
                    {
                        children = new List<Node>
                        {
                            new Node("E"),
                            new Node("F"){
                                children = new List<Node>
                                {
                                    new Node("I"),
                                    new Node("J")
                                }
                            }
                        }
                    },
                    new Node("C"),
                    new Node("D"){
                        children = new List<Node>
                        {
                            new Node("G"){
                                children = new List<Node>
                                {
                                    new Node("K")
                                }
                            },
                            new Node("H")
                        }
                    }
                }
            };

            List<string> expected = new List<string> 
                {"A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H"};

            List<string> actual = new List<string>();
            actual = tree.Solution1(null);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
