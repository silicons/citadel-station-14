namespace Content.Shared._Citadel.Procedural.Jigsaw;

public sealed class JigsawBufferTile<TPieceData, TTileData, TEdgeData>
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    public JigsawBufferTile(
        JigsawTile<TTileData, TEdgeData> tile,
        JigsawBufferPlaced<TPieceData, TTileData, TEdgeData>? placed
        )
    {
        this.Tile = tile;
        this.Placed = placed;
    }

    public JigsawTile<TTileData, TEdgeData> Tile { get; }
    public JigsawBufferPlaced<TPieceData, TTileData, TEdgeData>? Placed { get; }
}
