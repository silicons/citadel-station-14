namespace Content.Shared._Citadel.Procedural.Jigsaw;

/// <summary>
/// Direction for jigsaw pieces to be placed.
/// NORTH is the 'natural' direction.
/// Rotation is done logically clockwise; 'EAST' is a 90 deg CW, 'WEST' is a 270 deg CW.
/// </summary>
[Flags]
public enum JigsawDirection
{
    North = 1 << 0,
    East = 1 << 2,
    South = 1 << 1,
    West = 1 << 3,
}
