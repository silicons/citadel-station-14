using Content.Shared._Citadel.DSA.Jigsaw2D;

namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
/// Interface for solvers.
/// Solvers are less restrained than adjudicators, and may be stateful.
/// </summary>
public interface IJigsawSolver<TSolverParams, TPieceData, TTileData, TEdgeData>
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    /// <summary>
    /// Attempts to place a single piece.
    /// This is often far less optimized than placing multiple pieces.
    /// </summary>
    /// <param name="buffer"></param>
    /// <param name="piece"></param>
    /// <param name="solverParams"></param>
    /// <returns></returns>
    BufferPlacement<TPieceData, TTileData, TEdgeData> PlaceStandalonePiece(
        Buffer<TPieceData, TTileData, TEdgeData> buffer,
        Piece<TPieceData, TTileData, TEdgeData> piece,
        TSolverParams solverParams);
}
