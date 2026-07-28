namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
/// Decides whether two tiles can be next to each other.
/// </summary>
/// <typeparam name="TTileData"></typeparam>
/// <typeparam name="TPieceData"></typeparam>
/// <typeparam name="TEdgeData"></typeparam>
public interface IJigsawAdjudicator<TPieceData, TTileData, TEdgeData>
{
    bool CanEdgeJoin(JigsawTileEdge<TEdgeData> alpha, JigsawTileEdge<TEdgeData> beta);
}
