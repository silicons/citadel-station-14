namespace Content.Shared._Citadel.DSA.Jigsaw2D;

/// <summary>
/// A single tile of a jigsaw puzzle. Stores data on whether it can
/// join to other tiles.
/// </summary>
public struct Tile<TTileData, TEdgeData>()
    where TTileData : struct
    where TEdgeData : struct
{
    public TTileData Data;

    public Edge<TEdgeData> North;
    public Edge<TEdgeData> East;
    public Edge<TEdgeData> South;
    public Edge<TEdgeData> West;

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
