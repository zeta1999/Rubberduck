using Antlr4.Runtime;
using Rubberduck.Inspections.Abstract;
using Rubberduck.Inspections.Concrete;
using Rubberduck.Parsing;
using Rubberduck.Parsing.Grammar;
using Rubberduck.Parsing.Inspections.Abstract;
using Rubberduck.Parsing.Rewriter;
using Rubberduck.Parsing.VBA;

namespace Rubberduck.Inspections.QuickFixes
{
    public sealed class ReplaceGlobalModifierQuickFix : QuickFixBase
    {
        private readonly RubberduckParserState _state;

        public ReplaceGlobalModifierQuickFix(RubberduckParserState state)
            : base(typeof(ObsoleteGlobalInspection))
        {
            _state = state;
        }

        public override void Fix(IInspectionResult result, IRewriteSession rewriteSession = null)
        {
            var rewriter = _state.GetRewriter(result.Target);
            rewriter.Replace(((ParserRuleContext)result.Context.Parent.Parent).GetDescendent<VBAParser.VisibilityContext>(), Tokens.Public);
        }

        public override string Description(IInspectionResult result) => Resources.Inspections.QuickFixes.ObsoleteGlobalInspectionQuickFix;

        public override bool CanFixInProcedure => false;
        public override bool CanFixInModule => true;
        public override bool CanFixInProject => true;
    }
}