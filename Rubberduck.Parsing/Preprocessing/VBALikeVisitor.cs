//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Splinter\Documents\Visual Studio 2015\Projects\TestProj\TestProj\VBALike.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Rubberduck.Parsing.Like {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="VBALikeParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public interface IVBALikeVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="VBALikeParser.likePatternString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLikePatternString([NotNull] VBALikeParser.LikePatternStringContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBALikeParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompilationUnit([NotNull] VBALikeParser.CompilationUnitContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBALikeParser.likePatternCharlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLikePatternCharlist([NotNull] VBALikeParser.LikePatternCharlistContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBALikeParser.likePatternElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLikePatternElement([NotNull] VBALikeParser.LikePatternElementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBALikeParser.likePatternCharlistElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLikePatternCharlistElement([NotNull] VBALikeParser.LikePatternCharlistElementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="VBALikeParser.likePatternCharlistRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLikePatternCharlistRange([NotNull] VBALikeParser.LikePatternCharlistRangeContext context);
}
} // namespace Rubberduck.Parsing.Like
