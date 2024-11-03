/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start


public class MinStack
{

    private Stack<int> NumbersStack { get; set; } = new Stack<int>();
    private Stack<int> PreviousMinStack { get; set; } = new Stack<int>();

    public MinStack()
    {
    }

    public void Push(int val)
    {
        NumbersStack.Push(val);

        if (PreviousMinStack.Count == 0 || val <= PreviousMinStack.Peek())
            PreviousMinStack.Push(val);

    }

    public void Pop()
    {
        var popped = NumbersStack.Pop();

        if (popped == PreviousMinStack.Peek())
            PreviousMinStack.Pop();
    }

    public int Top()
    {
        return NumbersStack.Peek();
    }

    public int GetMin()
    {
        return PreviousMinStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

