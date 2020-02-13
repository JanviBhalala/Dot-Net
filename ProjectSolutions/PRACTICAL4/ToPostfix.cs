using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRACTICAL4
{
    class ToPostfix
    {
        internal String ifixTopostfix(string infix,out string postfix)
        {
            char c;
            postfix = "";
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < infix.Length; i++)
            {
                c = infix[i];
                if (isOperator(c))
                {
                    if (stack.Count()==0)
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        if (c=='(')
                        {
                            stack.Push(c);
                        }
                        else if (c == ')')
                        {
                            while (stack.Peek()!='(')
                            {
                                postfix += stack.Pop();
                            }
                            stack.Pop();
                        }
                        else if (priority(c) > priority(stack.Peek()))
                        {
                            stack.Push(c);
                        }
                        else
                        {
                            while (priority(c) < priority(stack.Peek()))
                            {
                                postfix += stack.Pop();
                            }
                        }
                    }
                }
                else
                {
                    postfix += c;
                }
            }
            while (stack.Count != 0)
            {
                postfix += stack.Pop();
            }

            return postfix;
        }

        private int priority(char c)
        {
            int prio=0;
            switch (c) {
                case '+':
                    prio = 1;
                    break;
                case '-':
                    prio = 1;
                    break;
                case '*':
                    prio = 2;
                    break;
                case '/':
                    prio = 2;
                    break;
          
            }
            return prio;
        }

        private bool isOperator(char v)
        {
            if (v<'a' || v>'z') {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
