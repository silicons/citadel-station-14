using System.Collections.Immutable;

namespace Content.Shared._Citadel.Procedural.Jigsaw;

public sealed class JigsawBufferPlaced<TPieceData, TTileData, TEdgeData>
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    private JigsawPiece<TPieceData, TTileData, TEdgeData> Piece { get; }
    public ImmutableList<JigsawBufferTile<TPieceData, TTileData, TEdgeData>> Tiles { get; }
    public JigsawDirection Direction { get; }
}
