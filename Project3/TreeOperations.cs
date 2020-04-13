using System;
using System.Collections.Generic;

namespace Project3
{
  public class TreeOperations
  {
    public static List<T> BFS<T>(Node<T> root)
    {
      if (root == null)
      {
        return new List<T>();
      }

      var result = new List<T>();

      var queue = new Queue<Node<T>>();

      queue.Enqueue(root);

      while (queue.Count > 0)
      {
        var element = queue.Dequeue();

        result.Add(element.Contents);

        if (element.Left != null)
        {
          queue.Enqueue(element.Left);
        }
        if (element.Right != null)
        {
          queue.Enqueue(element.Right);
        }
      }

      return result;
    }

    public static List<T> Preorder<T>(Node<T>? root) {
      var result = new List<T>();
      if (root != null) {
        result.AddRange(Preorder(root.Left));
        result.AddRange(Preorder(root.Right));
      }
      return result;
    }

    public static int MaxDepth<T>(Node<T> root) {
      if (root == null)
      {
        return 0;
      }

      var result = 0;


      return result;
    }
  }
}
