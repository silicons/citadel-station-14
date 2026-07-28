namespace Content.Shared._Citadel.Procedural.Jigsaw;

public sealed class JigsawPiece<TPieceData, TTileData, TEdgeData>(int width, int height)
    where TPieceData : struct
    where TTileData : struct
    where TEdgeData : struct
{
    public JigsawPattern<TTileData, TEdgeData> Pattern = new(width, height);
    public TPieceData Data;
}
