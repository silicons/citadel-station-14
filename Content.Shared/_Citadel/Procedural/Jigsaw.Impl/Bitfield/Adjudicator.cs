namespace Content.Shared._Citadel.Procedural.Jigsaw.Impl.Bitfield;

public sealed class Adjudicator<TPieceData, TTileData> : IJigsawAdjudicator<
    TPieceData, TTileData, Edge>
    where TPieceData : struct
    where TTileData : struct
{
    public bool CanEdgeJoin(JigsawTileEdge<Edge> alpha, JigsawTileEdge<Edge> beta)
    {
#warning impl
        throw new NotImplementedException();
    }

    public bool CanEdgeTouch(JigsawTileEdge<Edge> alpha, JigsawTileEdge<Edge> beta)
    {
#warning impl
        throw new NotImplementedException();
    }
}
