using MRubyD.Internals;

namespace MRubyD;

public enum BreakTag
{
    Break,
    Jump,
    Stop,
}

public sealed class RBreak : RObject
{
    public required int BreakIndex { get; init; }
    public required MRubyValue Value { get; init; }
    public BreakTag Tag { get; set; }

    internal RBreak() : base(InternalMRubyType.Break, null!)
    {
    }
}

