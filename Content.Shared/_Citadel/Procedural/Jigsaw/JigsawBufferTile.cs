namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
/// A tile that's in a buffer.
/// Edge orientation will be automatically fitted to the buffer & the current orientation.
/// </summary>
public sealed class JigsawBufferTile<TPieceData, TTileData, TEdgeData> where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    public TTileData Data;

    public JigsawBufferPlaced<TPieceData, TTileData, TEdgeData>? Placed;

    /**
     * The weight of this tile as a hint to solvers.
     *
     * The higher it is, the more prioritized it is to be joined first.
     *
     * Tiles that are more picky generally be more weighty, because
     * otherwise, less picky tiles (and their edges) may get 'first pick' and choke them out.
     */
    public int Weight = 0;

    /// <summary>
    /// Constructs a buffer tile.
    /// </summary>
    /// <param name="placed">The piece being placed.</param>
    /// <param name="tile">The tile on the piece</param>
    /// <param name="orientation">Orientation. This will automatically handle rotation of edge data.</param>
    /// <param name="x">X on the buffer this is being placed on</param>
    /// <param name="y">Y on the buffer this is being placed on</param>
    public JigsawBufferTile(JigsawBufferPlaced<TPieceData, TTileData, TEdgeData> placed,
        JigsawTile<TTileData, TEdgeData> tile,
        JigsawDirection orientation,
        int x,
        int y)
    {
        Placed = placed;
#warning impl
    }

    // @formatter:off
    public JigsawEdge<TEdgeData> North;
    public JigsawEdge<TEdgeData> East;
    public JigsawEdge<TEdgeData> South;
    public JigsawEdge<TEdgeData> West;
    // @formatter:on
}
