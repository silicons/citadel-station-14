namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
/// A single tile of a jigsaw puzzle. Stores data on whether it can
/// join to other tiles.
/// </summary>
public struct JigsawTile<TTileData, TEdgeData>()
    where TTileData : struct
    where TEdgeData : struct
{
    public TTileData Data;

    public JigsawEdge<TEdgeData> North;
    public JigsawEdge<TEdgeData> East;
    public JigsawEdge<TEdgeData> South;
    public JigsawEdge<TEdgeData> West;

    /**
     * The weight of this tile as a hint to solvers.
     *
     * The higher it is, the more prioritized it is to be joined first.
     *
     * Tiles that are more picky generally be more weighty, because
     * otherwise, less picky tiles (and their edges) may get 'first pick' and choke them out.
     */
    public int Weight = 0;
}
