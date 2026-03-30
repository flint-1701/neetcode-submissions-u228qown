public class Solution {
    public int EvalRPN(string[] tokens)
{
    Stack<int> temp = new Stack<int>();

    foreach (var token in tokens)
    {
        switch (token)
        {
            case "+":
                {
                    int b = temp.Pop();
                    int a = temp.Pop();
                    temp.Push(a + b);
                    break;
                }
            case "-":
                {
                    int b = temp.Pop();
                    int a = temp.Pop();
                    temp.Push(a - b);
                    break;
                }
            case "*":
                {
                    int b = temp.Pop();
                    int a = temp.Pop();
                    temp.Push(a * b);
                    break;
                }
            case "/":
                {
                    int b = temp.Pop();
                    int a = temp.Pop();
                    temp.Push(a / b); // integer division
                    break;
                }
            default:
                temp.Push(Convert.ToInt32(token));
                break;
        }
    }

    return temp.Peek();
}

}
