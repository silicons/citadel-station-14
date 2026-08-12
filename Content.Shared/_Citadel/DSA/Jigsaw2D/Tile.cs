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

}
