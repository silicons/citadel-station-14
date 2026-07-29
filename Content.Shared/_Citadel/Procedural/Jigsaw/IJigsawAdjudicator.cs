namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
/// Decides whether two tiles can be next to each other.
/// </summary>
/// <typeparam name="TTileData"></typeparam>
/// <typeparam name="TPieceData"></typeparam>
/// <typeparam name="TEdgeData"></typeparam>
public interface IJigsawAdjudicator<TPieceData, TTileData, TEdgeData>
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    /// <summary>
    /// Checks if two jigsaw edges may join each other naturally.
    /// Join is defined by being directly adjacent to that side.
    /// </summary>
    /// <param name="alpha"></param>
    /// <param name="beta"></param>
    /// <returns></returns>
    bool CanEdgeJoin(JigsawTileEdge<TEdgeData> alpha, JigsawTileEdge<TEdgeData> beta);

    /// <summary>
    /// Check if two jigsaw edges may touch at all.
    /// </summary>
    /// <param name="alpha"></param>
    /// <param name="beta"></param>
    /// <returns></returns>
    bool CanEdgeTouch(JigsawTileEdge<TEdgeData> alpha, JigsawTileEdge<TEdgeData> beta);
}
