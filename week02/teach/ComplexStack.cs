public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();

        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

/*
Hypothesis:
This program uses a stack to verify that all parentheses (), brackets [],
and braces {} in a string are correctly matched and properly nested.
Whenever an opening symbol is found, it is pushed onto the stack.
Whenever a closing symbol is found, the program checks whether it matches
the most recent opening symbol by popping the stack.
The function returns true if all symbols are matched correctly and the
stack is empty at the end; otherwise, it returns false.
*/