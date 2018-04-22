using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACOB1
{
   class Program
    {
        static void Main(string[] args)
        {



            // HI Jacob can you please comment out each code & run individually because i couldn't create menu sorry and please see about the brackets. .
            // In the last question you have to remove the "Class program & static void from top & need to put numbers in last then can run the program , one closing bracket required at last"
            //Thanks!

//---------------Question1----------------------------------------------------------------------------------------------------//

/*Queue q = new Queue();
q.Enqueue('K');
q.Enqueue('A');
q.Enqueue('R');
q.Enqueue('A');
q.Enqueue('N');

Console.WriteLine("Current queue: ");
foreach (char c in q)
{
    Console.Write(c + " ");
}
Console.ReadLine();
AddItem(q);
DeleteItem(q);
ShowNumberOfItems(q);
FindAnItem(q);
}

static void AddItem(Queue q)
{
Console.WriteLine("Enter a value that you want to add to Queue: ");
string input = Console.ReadLine();
q.Enqueue(input);
Console.WriteLine("Current queue: ");
foreach (var i in q)
{
    Console.Write(i + " ");
}
Console.ReadLine();
}


static void DeleteItem(Queue q)
{
Console.WriteLine("Deleting some value: ");
Console.WriteLine(q.Dequeue());

Console.WriteLine("Current queue: ");
foreach (char c in q)
{
    Console.Write(c + " ");
}
Console.ReadLine();
}

static void ShowNumberOfItems(Queue q)
{
Console.WriteLine("Number of items in Queue: {0}", q.Count);
Console.ReadLine();
}

static void FindAnItem(Queue q)
{
Console.WriteLine(q.Peek());
Console.ReadLine();
}
}
}
*/

//-------------------Question2-----------------------------------------------------------------------------------------------------//

// Ask the user to enter a string
// Reverse that string
// Comparison
/*Stack<char> cstack = new Stack<char>();
    string input = Console.ReadLine();


    var inputToUpper = input.ToUpper(); //assuming case senstivity is not to be considered 

    foreach (char c in inputToUpper)
    {
        cstack.Push(c);
    }

    bool isPalindrome = true;
    var noOfItems = cstack.Count;

    for (int i = 0; i < noOfItems; i++)
    {
        if (inputToUpper[i] != cstack.Pop())
        {
            isPalindrome = false; break;
        }
    }

    if (isPalindrome)
    {
        Console.WriteLine("Palindrome");
    }
    else
    {
        Console.WriteLine("Non Palindrome");


    }
    string kj = Console.ReadLine();

}
}
}

*/

//----------------------Question3--------------------------------------------------------------------------------------------------------------//

/*Console.WriteLine("Enter a infix String (+,-,*,/,^, a to z only):");
String kj = Console.ReadLine();

char []infix= kj.ToCharArray();
if (!isValid(infix))
{
  Console.WriteLine("You have entered Invalid Character");
}
else
{
  postFix(infix);
}
Console.ReadKey();
}
static Boolean isValid(char []infix)
{
  for(int i=0;i<infix.Length;i++)
  {
      char ch = infix[i];
      if (!isChar(ch) && ch != '+' && ch != '-' && ch != '*' && ch != '/' && ch != '^' && ch != '(' && ch != ')')
      {
          Console.WriteLine(ch + " is not allowed");
          return false;
      }
  }
return true;
}
static void print(char []postfix,int length)
{
for(int i=0;i<=length;i++)
{
  Console.Write(postfix[i]);
}
}
static void postFix (char []infix)
{
Stack stack = new Stack(infix.Length);
char[] postfix = new char[infix.Length];
int j = 0;
Console.WriteLine("Scan\t\tStack\t\tPostfix");
for (int i=0;i<infix.Length;i++)
{
  if (isChar(infix[i]))
  {
      postfix[j] = infix[i];
      j++;
  }
  else
  {
      if(infix[i]==')')
      {
          while(stack.peep()!='(')
          {
              postfix[j] = stack.pop();
              j++;
          }
          stack.pop();
      }
      else if(infix[i]=='(')
      {
          stack.push(infix[i]);
      }
      else if ((prcd(stack.peep()))<prcd(infix[i]))
      {
          stack.push(infix[i]);
      }                
      else if((prcd(stack.peep())) >= prcd(infix[i]))
      {
          char c = stack.pop();
          postfix[j] = c;
          j++;
          stack.push(infix[i]);
      }
  }
  Console.Write(infix[i] + "\t\t");
  stack.print();
  print(postfix, j - 1);
  Console.Write("\n");
}
while (!stack.isEmpty())
{
  postfix[j] = stack.pop();
  j++;
  Console.Write("\t\t");
  stack.print();
  print(postfix, j - 1);
  Console.Write("\n");
}
Console.WriteLine("Postfix String:");
for(int i=0;i<postfix.Length;i++)
{
  Console.Write(postfix[i]);
}
}
static int prcd(char ch)
{
if (ch == '(' || ch == ')')
  return 1;
else if (ch == '+' || ch == '-')
  return 2;
else if (ch == '*' || ch == '/')
  return 3;
else if (ch == '^')
  return 4;
return 0;
}
static Boolean isChar(char ch)
{
if(ch >= 'a' && ch <= 'z')
{
  return true;
}
else if (ch >= 'A' && ch <= 'Z')
{
  return true;
}
return false;
}
}
public class Stack
{
char []array=null;
int top = -1;
public Stack(int size)
{
array = new char[size];
}
public Boolean isEmpty()
{
if (top == -1)
{
  return true;
}
return false;
}
public char peep()  
{
if (!isEmpty())
{
  return array[top];   
}
return 'Z';
}
public void push(char ch)
{
top++;
array[top] = ch;
}
public char pop()
{
if (!isEmpty())
{
  char ch = array[top];
  top--;
  return ch;
}
return 'Z';
}
public void print()
{
for(int i=0;i<= top;i++)
{
  Console.Write(array[i]);
}
Console.Write("\t\t");
}

   }
}
*/

//--------------Question4-----------------------------------------------------------------------------------------------------------------------//

/*class Parser
  {
      public delegate int BinOp(int a, int b);
      static int add(int a, int b) { return a + b; }
      static int sub(int a, int b) { return a - b; }
      static int mul(int a, int b) { return a * b; }
      static int div(int a, int b) { return a / b; }

      static int parseExp(string s)
      {
          Dictionary<string, BinOp> oper = new Dictionary<string, BinOp>();
          List<int> stack = new List<int>();

          oper["+"] = add;
          oper["-"] = sub;
          oper["*"] = mul;
          oper["/"] = div;

          Regex rxnum = new Regex(@"\G\s*-?([0-9]+)\s+");
          Regex rxop = new Regex(@"\G(\+|\-|\*|\/)");
          int start = 0;
          do
          {
              Match m = rxnum.Match(s, start);
              if (m.Success)
              {
                  stack.Add(Int32.Parse(m.ToString()));
              }
              else
              {
                  m = rxop.Match(s, start);
                  if (m.Success)
                  {
                      int c = stack.Count;
                      if (c < 2) throw new Exception("Invalid expression: out of stack.");
                      stack[c - 2] = oper[m.ToString()](stack[c - 2], stack[c - 1]);
                      stack.RemoveAt(c - 1);
                  }
                  else break;
              }
              start = start + m.Length;
          } while (true);

          if (stack.Count != 1) throw new Exception("Invalid expression: more than one result on stack.");
          if (start != s.Length) throw new Exception("Invalid expression: unrecognized token.");

          return stack[0];
      }

      static void Main()
      {
          string exp = "8 5 - 12 *";
          Console.WriteLine("expression '{0}' result is '{1}'", exp, Parser.parseExp(exp));
          Console.ReadKey();
      }
  }
}
*/






