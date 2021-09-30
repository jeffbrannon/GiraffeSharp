using System;

namespace CodeAnalysis
{
    public class Class1
    {
    }
}



//using Microsoft.CodeAnalysis.CSharp;
//using Microsoft.CodeAnalysis.CSharp.Scripting;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
//using Microsoft.CodeAnalysis.Scripting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    public class Jeff
//    {
//        public int c;
//        public int d;

//        public Dictionary<string, int> Vars = new Dictionary<string, int>();
//    }

//    class Program
//    {
//        static object f1;
//        static object f2;
//        static object f3;
//        static void Main(string[] args)
//        {
//            Test();

//            var e = SyntaxFactory.ParseExpression("(6 + 4) - b");


//            Console.WriteLine("Hello World!");
//            Console.ReadLine();
//        }

//        static async Task Test()
//        {

//            var tree = CSharpSyntaxTree.ParseText("x = 10 + 6; let y = 7 - x;");
//            var root = (CompilationUnitSyntax)tree.GetRoot();
//            var variableDeclarations = root.DescendantNodes().OfType<VariableDeclarationSyntax>();

//            Console.WriteLine("Declare variables:");

//            foreach (var variableDeclaration in variableDeclarations)
//                Console.WriteLine($"Left: {variableDeclaration.Variables[0].Identifier.Value}, Right: {variableDeclaration.Variables[0].Initializer.Value}");

//            var variableAssignments = root.DescendantNodes().OfType<AssignmentExpressionSyntax>();

//            Console.WriteLine("Assign variables:");

//            foreach (var variableAssignment in variableAssignments)
//                Console.WriteLine($"Left: {variableAssignment.Left}, Right: {variableAssignment.Right}");






//            var jeff = new Jeff { };

//            var commandLine1 = "Vars[\"x\"] = 10;";
//            var commandLine2 = "Vars[\"y\"] = Vars[\"x\"] + 5;";

//            var state = await CSharpScript.RunAsync(commandLine1, ScriptOptions.Default, jeff);
//            state = await CSharpScript.RunAsync(commandLine2, ScriptOptions.Default, jeff);

//            //var x = state.Variables[0];



//            //ScriptState state = await CSharpScript.RunAsync("var e = 12; var jeff = e - 4*2");
//            //var value1 = state.Variables[0];
//            //var value2 = state.Variables[1];

//            bool result = await CSharpScript.EvaluateAsync<bool>("1 > 2");

//            f1 = await CSharpScript.RunAsync("1 > 2");

//            f2 = await CSharpScript.RunAsync("(3-1) == 2");

//            var f4 = await CSharpScript.RunAsync("c = 5 + 6; d = 5;", ScriptOptions.Default, jeff);

//            Console.WriteLine(jeff.c);
//            Console.WriteLine(jeff.d);
//        }
//    }
//}

