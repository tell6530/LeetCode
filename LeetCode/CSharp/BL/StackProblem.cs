using System.Collections;
using System.Collections.Generic;
using LeetCode.CSharp.BE;

namespace LeetCode.CSharp.BL
{
    public class StackProblem
    {
        /// <summary>
        /// No.20 Valid Parentheses(Easy)
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>
        /// Is parentheses valid
        /// </returns>
        public bool IsValid(string s)
        {
            var stack = new Stack();

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '('){
                    stack.Push('(');
                }else if(s[i] == '['){
                    stack.Push('[');
                }else if(s[i] == '{'){
                    stack.Push('{');
                }else if(s[i] == ')'){
                    if(stack.Count != 0 && (char)stack.Peek() == '(') stack.Pop();
                    else return false;
                }else if(s[i] == ']'){
                    if(stack.Count != 0 && (char)stack.Peek() == '[') stack.Pop();
                    else return false;
                }else if(s[i] == '}'){
                    if(stack.Count != 0 && (char)stack.Peek() == '{') stack.Pop();
                    else return false;
                }
            }

            return stack.Count == 0;
        }
    }
}