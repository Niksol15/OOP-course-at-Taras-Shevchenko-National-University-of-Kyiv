//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\Project\OOP\OOP-course-at-Taras-Shevchenko-National-University-of-Kyiv\MyExel\MyExel.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MyExel {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MyExelParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMyExelVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>MultiplicativeExpr</c>
	/// labeled alternative in <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpr([NotNull] MyExelParser.MultiplicativeExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>AdditiveExpr</c>
	/// labeled alternative in <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpr([NotNull] MyExelParser.AdditiveExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NumberExpr</c>
	/// labeled alternative in <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberExpr([NotNull] MyExelParser.NumberExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>IdentifierExpr</c>
	/// labeled alternative in <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpr([NotNull] MyExelParser.IdentifierExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>ParenthesizedExpr</c>
	/// labeled alternative in <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpr([NotNull] MyExelParser.ParenthesizedExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>NotExpr</c>
	/// labeled alternative in <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpr([NotNull] MyExelParser.NotExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>MinMaxExpr</c>
	/// labeled alternative in <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMinMaxExpr([NotNull] MyExelParser.MinMaxExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>LogicalExpr</c>
	/// labeled alternative in <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalExpr([NotNull] MyExelParser.LogicalExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyExelParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] MyExelParser.CompileUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyExelParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] MyExelParser.ExpressionContext context);
}
} // namespace MyExel
