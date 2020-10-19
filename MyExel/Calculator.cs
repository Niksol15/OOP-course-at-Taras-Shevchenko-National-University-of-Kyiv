using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Antlr4.Runtime;

namespace MyExel
{
    public static class Calculator
    {

        private static List<string> _parsedIdentifiers = new List<string>();
        public static List<string> GetParsedIdentifiers()
        {
            return _parsedIdentifiers;
        }
        public static string Evaluate(string expression)
        {
            _parsedIdentifiers.Clear();
            var lexer = new MyExelLexer(new AntlrInputStream(expression));
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowExceptionErrorListener());
            var tokens = new CommonTokenStream(lexer);
            var parser = new MyExelParser(tokens);
            var tree = parser.compileUnit();
            var visitor = new MyExelVisitor();
            double res = visitor.Visit(tree);
            _parsedIdentifiers = visitor.GetParsedIdentifiers();
            return res.ToString();
        }
    }
}
