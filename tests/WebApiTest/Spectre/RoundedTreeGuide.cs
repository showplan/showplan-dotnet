using Spectre.Console;
using Spectre.Console.Rendering;

namespace WebApiTest;

public sealed class RoundedTreeGuide : TreeGuide
{
    /// <inheritdoc/>
    public override string GetPart(TreeGuidePart part)
    {
        return part switch
        {
            TreeGuidePart.Space => "    ",
            TreeGuidePart.Continue => " │  ",
            TreeGuidePart.Fork => " ├──",
            TreeGuidePart.End => " ╰──",
            _ => throw new ArgumentOutOfRangeException(nameof(part), part, "Unknown tree part."),
        };
    }
}
