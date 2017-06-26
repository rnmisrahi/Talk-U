using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareText
{
  class Node
  {
    String word;
    int count;
    Node left;
    Node right;

    public Node()
    {
      word = "";
      count = 0;
      left = null;
      right = null;       
    }

    public Node(string word)
    {
      this.word = word;
      count = 1;
      left = null;
      right = null;
    }

    public void add(Node node, string word)
    {
      if (node == null)
      {
        node = new Node(word);
      }
      else
      {
        int n = String.Compare(word, node.word);
        if (n == 0)
        {
          node.count++;
        }
        else
        {
          if (n < 0)
          {
            add(node.left, word);
          }
          else
          {
            add(node.right, word);
          }
        }
      }
    }

    public void visit(Node node)
    {
      if (node != null)
      {
        if (node.left == null)
        {
          Console.WriteLine(node.word);
          visit(node.right);
        }
        else
        {
          visit(node.left);
        }
      }
    }
  }
}
