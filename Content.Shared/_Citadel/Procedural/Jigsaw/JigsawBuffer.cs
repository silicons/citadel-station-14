namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
///
/// </summary>
/// <typeparam name="TPieceData">
/// Data stored on placed pieces.
/// </typeparam>
/// <typeparam name="TTileData">
/// Data stored on tiles.
/// </typeparam>
/// <typeparam name="TEdgeData">Data stored on tile edges</typeparam>
public sealed class JigsawBuffer<TPieceData, TTileData, TEdgeData>
{
    private int Width { get; }
    private int Height { get; }

    private List<JigsawBufferPlaced<TPieceData>> placed;
    private List<JigsawBufferTile<TPieceData, TTileData>?> tiles;

    /// <summary>
    ///
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <typeparam name="TTileData">
    /// Data stored on tiles.
    /// </typeparam>
    /// <typeparam name="TPieceData">
    /// Data stored on placed.
    /// </typeparam>
    public JigsawBuffer(int width, int height)
    {
        Width = width;
        Height = height;
        placed = new List<JigsawBufferPlaced<TPieceData>>();
        tiles = new List<JigsawBufferTile<TTileData, TPieceData>?>();
    }
}

