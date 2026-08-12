namespace Content.Shared._Citadel.DSA.Jigsaw2D;

/// <summary>
/// A single piece of a jigsaw puzzle.
/// <br />
/// Pieces may be arbitrarily rotated while placed.
/// <br />
/// Pieces will be rotated clockwise if non-NORTH.
/// </summary>
/// <param name="pattern"></param>
/// <typeparam name="TPieceData"></typeparam>
/// <typeparam name="TTileData"></typeparam>
/// <typeparam name="TEdgeData"></typeparam>
public sealed class Piece<TPieceData, TTileData, TEdgeData>(Pattern<TTileData, TEdgeData> pattern)
    : ICloneable
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    public readonly Pattern<TTileData, TEdgeData> Pattern =
        pattern.Clone() as Pattern<TTileData, TEdgeData> ??
        throw new InvalidOperationException("Null pattern in JigsawPiece constructor.");

    public TPieceData Data;

    /**
     * The weight of this piece as a hint to solvers.
     *
     * The higher it is, the more prioritized it is to be joined first.
     *
     * Pieces that are more picky generally be more weighty, because
     * otherwise, less picky pieces may get 'first pick' and choke them out.
     */
    public int Weight = 0;

    public object Clone()
    {
#warning impl
        throw new NotImplementedException();
    }
}
