using Spectre.Console;
using Spectre.Console.Rendering;

namespace WebApiTest;

/// <summary>
/// A renderable panel.
/// </summary>
public sealed class TreePanel : Renderable, IHasBoxBorder, IHasBorder, IExpandable, IPaddable
{
    private const int EdgeWidth = 2;

    private readonly IRenderable _child;
    private readonly bool _hasChildren;

    public BoxBorder Border { get; set; } = BoxBorder.Rounded;

    public bool UseSafeBorder { get; set; } = true;

    public Style? BorderStyle { get; set; } = new Style(Color.Grey);

    public bool Expand { get; set; }

    public Padding? Padding { get; set; } = new Padding(1, 0, 1, 0);

    public PanelHeader? Header { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether or not the panel is inlined.
    /// </summary>
    internal bool Inline { get; set; }


    public TreePanel(IRenderable content, bool hasChildren)
    {
        _child = content ?? throw new ArgumentNullException(nameof(content));
        _hasChildren = hasChildren;
    }

    protected override Measurement Measure(RenderContext context, int maxWidth)
    {
        var child = new Padder(_child, Padding);
        var childWidth = ((IRenderable)child).Measure(context, maxWidth);
        return new Measurement(
            childWidth.Min + EdgeWidth,
            childWidth.Max + EdgeWidth);
    }

    protected override IEnumerable<Segment> Render(RenderContext context, int maxWidth)
    {
        var edgeWidth = EdgeWidth;

        var border = BoxExtensions.GetSafeBorder(Border, !context.Unicode && UseSafeBorder);
        var borderStyle = BorderStyle ?? Style.Plain;

        var showBorder = true;
        if (border is NoBoxBorder)
        {
            showBorder = false;
            edgeWidth = 0;
        }

        var child = new Padder(_child, Padding);
        var childWidth = maxWidth - edgeWidth;

        if (!Expand)
        {
            var measurement = ((IRenderable)child).Measure(context, maxWidth - edgeWidth);
            childWidth = measurement.Max;
        }

        var panelWidth = childWidth + edgeWidth;
        panelWidth = Math.Min(panelWidth, maxWidth);
        childWidth = panelWidth - edgeWidth;

        var result = new List<Segment>();

        if (showBorder)
        {
            // Panel top
            AddTopBorder(result, context, border, borderStyle, panelWidth);
        }

        // Split the child segments into lines.
        var childSegments = ((IRenderable)child).Render(context, childWidth);
        foreach (var (index, _, last, line) in Segment.SplitLines(childSegments, childWidth).Enumerate())
        {
            if (line.Count == 1 && line[0].IsWhiteSpace)
            {
                // NOTE: This check might impact other things.
                // Hopefully not, but there is a chance.
                continue;
            }

            if (showBorder)
            {
                if (index == 0)
                {
                    result.Add(new Segment("┤", borderStyle));
                }
                else
                {
                    result.Add(new Segment(border.GetPart(BoxBorderPart.Left), borderStyle));
                }
            }

            var content = new List<Segment>();
            content.AddRange(line);

            // Do we need to pad the panel?
            var length = line.Sum(segment => segment.CellCount());
            if (length < childWidth)
            {
                var diff = childWidth - length;
                content.Add(Segment.Padding(diff));
            }

            result.AddRange(content);

            if (showBorder)
            {
                result.Add(new Segment(border.GetPart(BoxBorderPart.Right), borderStyle));
            }

            // Don't emit a line break if this is the last
            // line, we're not showing the border, and we're
            // not rendering this inline.
            var emitLinebreak = !(last && !showBorder && !Inline);
            if (!emitLinebreak)
            {
                continue;
            }

            result.Add(Segment.LineBreak);
        }

        // Panel bottom
        if (showBorder)
        {
            result.Add(new Segment(border.GetPart(BoxBorderPart.BottomLeft), borderStyle));
            if (_hasChildren)
            {
                result.Add(new Segment("┬", borderStyle));
                result.Add(new Segment(border.GetPart(BoxBorderPart.Bottom).Repeat(panelWidth - EdgeWidth - 1), borderStyle));
            }
            else
            {
                result.Add(
                    new Segment(border.GetPart(BoxBorderPart.Bottom).Repeat(panelWidth - EdgeWidth), borderStyle));
            }

            result.Add(new Segment(border.GetPart(BoxBorderPart.BottomRight), borderStyle));
        }

        // TODO: Need a better name for this?
        // If we're rendering this as part of an inline parent renderable,
        // such as columns, we should not emit the last line break.
        if (!Inline)
        {
            result.Add(Segment.LineBreak);
        }

        return result;
    }

    private void AddTopBorder(
        List<Segment> result, RenderContext context, BoxBorder border,
        Style borderStyle, int panelWidth)
    {
        var rule = new Rule
        {
            Style = borderStyle, Border = border, Title = Header?.Text, Alignment = Header?.Alignment ?? Justify.Left,
        };

        // Top left border
        result.Add(new Segment(border.GetPart(BoxBorderPart.TopLeft), borderStyle));

        // Top border (and header text if specified)
        result.AddRange(((IRenderable)rule).Render(context, panelWidth - 2).Where(x => !x.IsLineBreak));

        // Top right border
        result.Add(new Segment(border.GetPart(BoxBorderPart.TopRight), borderStyle));
        result.Add(Segment.LineBreak);
    }
}
