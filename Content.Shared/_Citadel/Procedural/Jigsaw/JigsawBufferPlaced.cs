namespace Content.Shared._Citadel.Procedural.Jigsaw;

public sealed class JigsawBufferPlaced<TData>(TData data)
{
    public TData Data { get; } = data;
}
