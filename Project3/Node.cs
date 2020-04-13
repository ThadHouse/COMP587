namespace Project3
{
  public class Node<T>
  {
    public T Contents { get; }
    public Node<T>? Left { get; }
    public Node<T>? Right { get; }

    public Node(T contents, Node<T>? left, Node<T>? right) {
      Contents = contents;
      Left = left;
      Right = right;
    }
  }
}
