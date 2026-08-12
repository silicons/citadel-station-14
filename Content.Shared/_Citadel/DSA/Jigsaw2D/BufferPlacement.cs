using System.Collections.Immutable;

namespace Content.Shared._Citadel.DSA.Jigsaw2D;

public sealed class BufferPlacement<TPieceData, TTileData, TEdgeData>
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    internal BufferPlacement(Piece<TPieceData, TTileData, TEdgeData> piece,
        IEnumerable<BufferTile<TPieceData, TTileData, TEdgeData>> tiles,
        Orientation direction,
        int lowerLeftX,
        int lowerLeftY)
    {
        Piece = piece;
        Tiles = tiles.ToImmutableList();
        Direction = direction;
        LowerLeftX = lowerLeftX;
        LowerLeftY = lowerLeftY;
    }

    public Piece<TPieceData, TTileData, TEdgeData> Piece { get; }
    public ImmutableList<BufferTile<TPieceData, TTileData, TEdgeData>> Tiles { get; }
    public Orientation Direction { get; }

    public int LowerLeftX { get; }
    public int LowerLeftY { get; }
}
