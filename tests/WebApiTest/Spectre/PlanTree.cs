using Spectre.Console;
using Spectre.Console.Rendering;

namespace WebApiTest.Spectre;

/// <summary>
/// Representation of non-circular tree data.
/// Each node added to the tree may only be present in it a single time, in order to facilitate cycle detection.
/// </summary>
public sealed class PlanTree : Renderable, IHasPlanTreeNodes
{
    private readonly PlanTreeNode _root;

    /// <summary>
    /// Gets or sets the tree style.
    /// </summary>
    public Style? Style { get; set; }

    /// <summary>
    ///  Gets or sets the tree guide lines.
    /// </summary>
    public TreeGuide Guide { get; set; } = TreeGuide.Line;

    /// <summary>
    /// Gets the tree's child nodes.
    /// </summary>
    public List<PlanTreeNode> Nodes => _root.Nodes;

    /// <summary>
    /// Initializes a new instance of the <see cref="Tree"/> class.
    /// </summary>
    /// <param name="renderable">The tree label.</param>
    public PlanTree(IRenderable renderable)
    {
        _root = new PlanTreeNode(renderable, "");
    }

    /// <inheritdoc />
    protected override IEnumerable<Segment> Render(RenderContext context, int maxWidth)
    {
        var result = new List<Segment>();
        var visitedNodes = new HashSet<PlanTreeNode>();

        var stack = new Stack<Queue<PlanTreeNode>>();
        stack.Push(new Queue<PlanTreeNode>(new[] { _root }));

        var levels = new List<Segment>();
        levels.Add(GetGuide(context, TreeGuidePart.Continue));

        while (stack.Count > 0)
        {
            var stackNode = stack.Pop();
            if (stackNode.Count == 0)
            {
                levels.RemoveLast();
                if (levels.Count > 0)
                {
                    levels.AddOrReplaceLast(GetGuide(context, TreeGuidePart.Continue));
                }

                continue;
            }

            var isLastChild = stackNode.Count == 1;
            var current = stackNode.Dequeue();
            if (!visitedNodes.Add(current))
            {
                throw new Exception("Cycle detected in tree - unable to render.");
            }

            stack.Push(stackNode);

            if (isLastChild)
            {
                // levels.AddOrReplaceLast(GetGuide(context, TreeGuidePart.End));
            }

            var prefix = levels.Skip(1).ToList();
            var renderable = new TreePanel(current.Renderable, current.Nodes.Count > 0);
            if (string.IsNullOrWhiteSpace(current.Title) == false)
            {
                renderable.Header = new PanelHeader($"[white]{current.Title.EscapeMarkup()}[/]", Justify.Left);
            }

            var renderableLines =
                Segment.SplitLines(((IRenderable)renderable).Render(context, maxWidth - Segment.CellCount(prefix)));

            foreach (var (index, isFirstLine, _, line) in renderableLines.Enumerate())
            {
                if (prefix.Count > 0)
                {
                    result.AddRange(prefix.ToList());
                }

                result.AddRange(line);
                result.Add(Segment.LineBreak);

                if (isFirstLine && prefix.Count > 0)
                {
                    var part = isLastChild ? TreeGuidePart.End : TreeGuidePart.Fork;
                    prefix.AddOrReplaceLast(GetGuide(context, part));
                }

                if (index == 1 && prefix.Count > 0)
                {
                    var part = isLastChild ? TreeGuidePart.Space : TreeGuidePart.Continue;
                    prefix.AddOrReplaceLast(GetGuide(context, part));
                }
            }

            if (current.Expanded && current.Nodes.Count > 0)
            {
                levels.AddOrReplaceLast(GetGuide(context, isLastChild ? TreeGuidePart.Space : TreeGuidePart.Continue));
                levels.Add(GetGuide(context, TreeGuidePart.Continue));

                stack.Push(new Queue<PlanTreeNode>(current.Nodes));
            }
        }

        return result;
    }

    private Segment GetGuide(RenderContext context, TreeGuidePart part)
    {
        var guide = Guide.GetSafeTreeGuide(safe: !context.Unicode);
        return new Segment(guide.GetPart(part), Style ?? Style.Plain);
    }
}

/// <summary>
/// Represents a tree node.
/// </summary>
public sealed class PlanTreeNode : IHasPlanTreeNodes
{
    public string Title { get; set; }

    internal IRenderable Renderable { get; }

    /// <summary>
    /// Gets the tree node's child nodes.
    /// </summary>
    public List<PlanTreeNode> Nodes { get; } = new List<PlanTreeNode>();

    /// <summary>
    /// Gets or sets a value indicating whether or not the tree node is expanded or not.
    /// </summary>
    public bool Expanded { get; set; } = true;

    /// <summary>
    /// Initializes a new instance of the <see cref="TreeNode"/> class.
    /// </summary>
    /// <param name="renderable">The tree node label.</param>
    public PlanTreeNode(IRenderable renderable, string title)
    {
        Renderable = renderable;
        Title = title;
    }
}

public interface IHasPlanTreeNodes
{
    /// <summary>
    /// Gets the tree's child nodes.
    /// </summary>
    List<PlanTreeNode> Nodes { get; }
}

internal static class ListExtensions
{
    public static void RemoveLast<T>(this List<T> list)
    {
        if (list is null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        if (list.Count > 0)
        {
            list.RemoveAt(list.Count - 1);
        }
    }

    public static void AddOrReplaceLast<T>(this List<T> list, T item)
    {
        if (list is null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        if (list.Count == 0)
        {
            list.Add(item);
        }
        else
        {
            list[list.Count - 1] = item;
        }
    }
}
