namespace Content.Shared._Citadel.DSA.Jigsaw2D;

/// <summary>
/// A holder pattern for tiles in a jigsaw piece.
/// <br />
/// To be intuitive to humans, indices internally are north = ++y, south = --y, east = ++x, west = --x
/// </summary>
/// <typeparam name="TTileData"></typeparam>
/// <typeparam name="TEdgeData"></typeparam>
public sealed class Pattern<TTileData, TEdgeData> : ICloneable
    where TTileData : struct
    where TEdgeData : struct
{
    /// <summary>
    /// A null-ref that may be returned.
    /// </summary>
    private static Tile<TTileData, TEdgeData>? _nullTile;

    /// <summary>
    /// Tiles list. Created and sized at init.
    /// <br />
    /// Row-major, index = (y * width) + x.
    /// Indices start from 0.
    /// </summary>
    private readonly Tile<TTileData, TEdgeData>?[] _tiles;

    /// <summary>
    /// Creates a pattern with a given size.
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public Pattern(int width, int height)
    {
        Width = width;
        Height = height;

        _tiles = new Tile<TTileData, TEdgeData>?[width * height];
    }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    /// <param name="clone"></param>
    private Pattern(Pattern<TTileData, TEdgeData> clone)
        : this(clone.Width, clone.Height)
    {
        for (var i = 0; i < clone._tiles.Length; i++)
        {
            _tiles[i] = clone._tiles[i];
        }
    }

    public int Width { get; }
    public int Height { get; }

    public object Clone()
    {
        return new Pattern<TTileData, TEdgeData>(this);
    }

    public bool PlaceTile(Tile<TTileData, TEdgeData> tile,
        int x,
        int y,
        out Tile<TTileData, TEdgeData>? replaced)
    {
        if (!InBounds(x, y))
        {
            replaced = null;
            return false;
        }

        var index = IndexOf(x, y);
        replaced = _tiles[index];
        _tiles[index] = tile;
        return true;
    }

    public ref Tile<TTileData, TEdgeData>? GetTile(int x, int y)
    {
        if (!InBounds(x, y))
            return ref _nullTile;
        return ref _tiles[IndexOf(x, y)];
    }

    /// <summary>
    /// Gets the index of a tile.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    private int IndexOf(int x, int y)
    {
        return y * Width + x;
    }

    private bool InBounds(int x, int y)
    {
        var index = IndexOf(x, y);
        return index >= 0 && index < _tiles.Length;
    }
}
