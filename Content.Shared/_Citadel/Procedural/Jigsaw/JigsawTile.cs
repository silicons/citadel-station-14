namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
/// A single tile of a jigsaw puzzle. Stores data on whether it can
/// join to other tiles.
/// </summary>
public struct JigsawTile<TTileData, TEdgeData>
    where TTileData : struct
    where TEdgeData : struct
{
    public TTileData Data;

    public JigsawTileEdge<TEdgeData> North;
    public JigsawTileEdge<TEdgeData> East;
    public JigsawTileEdge<TEdgeData> South;
    public JigsawTileEdge<TEdgeData> West;
}
