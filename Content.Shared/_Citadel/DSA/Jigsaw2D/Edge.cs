namespace Content.Shared._Citadel.DSA.Jigsaw2D;

public struct Edge<TEdgeData>()
    where TEdgeData : struct
{
    public TEdgeData Data = default;

    /**
     * The weight of this edge as a hint to solvers.
     *
     * The higher it is, the more prioritized it is to be joined first.
     *
     * Edges that are more picky generally be more weighty, because
     * otherwise, less picky edges may get 'first pick' and choke them out.
     */
    public int Weight = 0;
}
