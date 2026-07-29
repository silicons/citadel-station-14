namespace Content.Shared._Citadel.Procedural.Jigsaw;

public sealed class JigsawPattern<TTileData, TEdgeData>
    where TTileData : struct
    where TEdgeData : struct
{
    private readonly List<JigsawTile<TTileData, TEdgeData>?> tiles;

    public JigsawPattern(int width, int height)
    {
        Width = width;
        Height = height;

        tiles = new List<JigsawTile<TTileData, TEdgeData>?>();
        for (var i = 0; i < width * height; i++)
        {
            tiles.Add(null);
        }
    }

    public int Width { get; }
    public int Height { get; }

    public bool PlaceTile(JigsawTile<TTileData, TEdgeData> tile,
        int x,
        int y,
        out JigsawTile<TTileData, TEdgeData>? replaced)
    {
#warning impl
    }

    private JigsawTile<TTileData, TEdgeData>? GetTile(int x, int y)
    {
#warning impl
    }

    private int indexOf(int x, int y)
    {
#warning impl
    }

    private bool inBounds(int x, int y)
    {
        var index = indexOf(x, y);
        return index >= 0 && index < tiles.Count;
    }
}
