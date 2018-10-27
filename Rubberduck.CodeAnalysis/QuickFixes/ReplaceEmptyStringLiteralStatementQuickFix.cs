using Rubberduck.Inspections.Abstract;
using Rubberduck.Inspections.Concrete;
using Rubberduck.Parsing.Inspections.Abstract;
using Rubberduck.Parsing.Rewriter;
using Rubberduck.Parsing.VBA;

namespace Rubberduck.Inspections.QuickFixes
{
    public sealed class ReplaceEmptyStringLiteralStatementQuickFix : QuickFixBase
    {
        private readonly RubberduckParserState _state;

        public ReplaceEmptyStringLiteralStatementQuickFix(RubberduckParserState state)
            : base(typeof(EmptyStringLiteralInspection))
        {
            _state = state;
        }

        public override void Fix(IInspectionResult result, IRewriteSession rewriteSession = null)
        {
            var rewriter = _state.GetRewriter(result.QualifiedSelection.QualifiedName);
            rewriter.Replace(result.Context, "vbNullString");
        }

        public override string Description(IInspectionResult result) => Resources.Inspections.QuickFixes.EmptyStringLiteralInspectionQuickFix;

        public override bool CanFixInProcedure => true;
        public override bool CanFixInModule => true;
        public override bool CanFixInProject => true;
    }
}