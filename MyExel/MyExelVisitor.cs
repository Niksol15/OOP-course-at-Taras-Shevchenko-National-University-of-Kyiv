using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MyExel
{
    class MyExelVisitor : MyExelBaseVisitor<double>
    {
        private HashSet<string> parsedIdentifires = new HashSet<string>();
        public List<string> GetParsedIdentifiers()
        {
            return parsedIdentifires.ToList();
        }
        public override double VisitCompileUnit(MyExelParser.CompileUnitContext context)
        {
            return Visit(context.expression());
        }
        public override double VisitNumberExpr(MyExelParser.NumberExprContext context)
        {
            var result = double.Parse(context.GetText());
            return result;
        }
        public override double VisitIdentifierExpr(MyExelParser.IdentifierExprContext context)
        {
            var result = context.GetText();
            parsedIdentifires.Add(result);
            if(CellManager.IdentifierToStringValue(result) == "null")
            {
                throw new NullCellException();
            }
            return Convert.ToDouble(CellManager.IdentifierToBoolValue(result));
        }
        public override double VisitParenthesizedExpr(MyExelParser.ParenthesizedExprContext context)
        {
            return Visit(context.expression());
        }
        public override double VisitNotExpr(MyExelParser.NotExprContext context)
        {
            return Convert.ToDouble(Visit(context.expression()) == 0.0);
        }
        public override double VisitAdditiveExpr(MyExelParser.AdditiveExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            switch (context.operatorToken.Type)
            {
                case MyExelLexer.ADD:
                    return left + right;
                case MyExelLexer.SUBTRACT:
                    return left - right;
                default:
                    return 0.0;
            }
        }
        public override double VisitMinMaxExpr(MyExelParser.MinMaxExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            switch (context.operatorToken.Type)
            {
                case MyExelLexer.MIN:
                    return Math.Min(left, right);
                case MyExelLexer.MAX:
                    return Math.Max(left, right);
                default:
                    return 0.0;
            }
        }
        public override double VisitLogicalExpr(MyExelParser.LogicalExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            switch (context.operatorToken.Type)
            {
                case MyExelLexer.GREATER:
                    return Convert.ToDouble(left > right);
                case MyExelLexer.LESS:
                    return Convert.ToDouble(left < right);
                case MyExelLexer.EQUAL:
                    return Convert.ToDouble(left == right);
                default:
                    return 0.0;
            }
        }
        public override double VisitMultiplicativeExpr(MyExelParser.MultiplicativeExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            switch (context.operatorToken.Type)
            {
                case MyExelLexer.MULTIPLY:
                    return left * right;
                case MyExelLexer.DIVIDE:
                    return left / right;
                case MyExelLexer.DIV:
                    return (int)left / (int)right;
                case MyExelLexer.MOD:
                    return (int)left % (int)right;
                default:
                    return 0.0;
            }
        }
        private double WalkLeft(MyExelParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<MyExelParser.ExpressionContext>(0));
        }
        private double WalkRight(MyExelParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<MyExelParser.ExpressionContext>(1));
        }

    }
}
