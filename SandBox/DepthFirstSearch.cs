using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoExpert
{
    public class DepthFirstSearch
    {
        public class Node {
            public string name;
            public List<Node> children = new List<Node>();

            public Node(string name) {
                this.name = name;
            }

            // O(v + e) Time | O(v) Space
            // Where v = vertices, e = edges
            public List<string> Solution1(List<string> array) {
                List<string> solution = new List<string>();
                solution.Add(this.name);

                foreach (var child in this.children)
                {
                    List<string> childSolution = child.Solution1(array);
                    solution.AddRange(childSolution);
                }

                return solution;
            }

            public Node AddChild(string name) {
                Node child = new Node(name);
                children.Add(child);
                return this;
            }
        }
    }
}
