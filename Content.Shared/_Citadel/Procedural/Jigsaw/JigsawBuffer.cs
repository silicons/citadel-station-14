namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
/// A buffer to place jigsaw pieces on.
/// <br />
/// To be intuitive to humans, indices internally are north = ++y, south = --y, east = ++x, west = --x
/// </summary>
/// <typeparam name="TPieceData">
/// Data stored on placed pieces.
/// </typeparam>
/// <typeparam name="TTileData">
/// Data stored on tiles.
/// </typeparam>
/// <typeparam name="TEdgeData">Data stored on tile edges</typeparam>
public sealed class JigsawBuffer<TPieceData, TTileData, TEdgeData>
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    private List<JigsawBufferPlaced<TPieceData, TTileData, TEdgeData>> placed;
    private List<JigsawBufferTile<TPieceData, TTileData, TEdgeData>?> tiles;

    /// <summary>
    /// Constructs a buffer with a given size.
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <typeparam name="TTileData">
    /// Data stored on tiles.
    /// </typeparam>
    /// <typeparam name="TPieceData">
    /// Data stored on placed pieces.
    /// </typeparam>
    public JigsawBuffer(int width, int height)
    {
        Width = width;
        Height = height;

        placed = new List<JigsawBufferPlaced<TPieceData, TTileData, TEdgeData>>();
        tiles = new List<JigsawBufferTile<TPieceData, TTileData, TEdgeData>?>();
    }

    public int Width { get; }

    public int Height { get; }
}
