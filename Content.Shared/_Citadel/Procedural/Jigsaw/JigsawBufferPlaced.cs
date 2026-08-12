using System.Collections.Immutable;

namespace Content.Shared._Citadel.Procedural.Jigsaw;

public sealed class JigsawBufferPlaced<TPieceData, TTileData, TEdgeData>
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    private JigsawBufferPlaced(JigsawPiece<TPieceData, TTileData, TEdgeData> piece,
        IEnumerable<JigsawBufferTile<TPieceData, TTileData, TEdgeData>> tiles,
        JigsawDirection direction)
    {
        Piece = piece;
        Tiles = tiles.ToImmutableList();
        Direction = direction;
    }

    public JigsawPiece<TPieceData, TTileData, TEdgeData> Piece { get; }
    public ImmutableList<JigsawBufferTile<TPieceData, TTileData, TEdgeData>> Tiles { get; }
    public JigsawDirection Direction { get; }
}
