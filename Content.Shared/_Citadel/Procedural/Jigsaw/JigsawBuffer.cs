namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
///
/// </summary>
/// <typeparam name="TTileData">
/// Data stored on tiles.
/// </typeparam>
/// <typeparam name="TPlacedData">
/// Data stored on placed pieces.
/// </typeparam>
public sealed class JigsawBuffer<TTileData, TPlacedData>
{
    private ulong Width { get; }
    private ulong Height { get; }

    private List<JigsawBufferPlaced<TPlacedData>> placed;
    private List<JigsawBufferTile<TTileData, TPlacedData>?> tiles;

    /// <summary>
    ///
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <typeparam name="TTileData">
    /// Data stored on tiles.
    /// </typeparam>
    /// <typeparam name="TPlacedData">
    /// Data stored on placed.
    /// </typeparam>
    public JigsawBuffer(ulong width, ulong height)
    {
        Width = width;
        Height = height;
        placed = new List<JigsawBufferPlaced<TPlacedData>>();
        tiles = new List<JigsawBufferTile<TTileData, TPlacedData>?>();
    }
}

