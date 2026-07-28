namespace Content.Shared._Citadel.Procedural.Jigsaw;

[Flags]
public enum JigsawDirection
{
    North = (1<<0),
    East = (1<<2),
    South = (1<<1),
    West = (1<<3),
}
