namespace Content.Shared._Citadel.Procedural.Jigsaw;

public sealed class JigsawBufferTile<TTileData, TPieceData>
{
    public JigsawBufferTile(JigsawTile<TTileData> tile, JigsawBufferPlaced<TPieceData>? placed)
    {
        this.tile = tile;
        this.placed = placed;
    }

    private JigsawTile<TTileData> tile;
    private JigsawBufferPlaced<TPieceData>? placed;
}
