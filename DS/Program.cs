//Implement a stack using arrays with push, pop and peek operations

public class Program
{
    public static void Main(string[] strings)
    {
        Stack stack = new Stack(5);
        stack.Push(1);
        stack.Push(2);

        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());

        Console.ReadKey();
    }
}

public class Stack
{
    private int[] elements;
    private int size;
    private int top;

    public Stack(int size)
    {
        elements = new int[size];
        this.size = size;
        top = -1;
    }

    public void Push(int element)
    {
        if (top == size - 1)
            throw new StackOverflowException("Stack is full");
        elements[++top] = element;
    }

    public int Pop()
    {
        if (top == -1)
            throw new InvalidOperationException("Stack is empty");
        return elements[top--];
    }

    public int Peek()
    {
        if (top == -1)
            throw new InvalidOperationException("Stack is empty");
        return elements[top];
    }
}

