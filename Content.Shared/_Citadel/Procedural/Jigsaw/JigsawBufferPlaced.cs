using System.Collections.Immutable;

namespace Content.Shared._Citadel.Procedural.Jigsaw;

public sealed class JigsawBufferPlaced<TPieceData, TTileData, TEdgeData>
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    #warning impl

    public ImmutableList<JigsawBufferTile<TPieceData, TTileData, TEdgeData>> Tiles { get; }
}
