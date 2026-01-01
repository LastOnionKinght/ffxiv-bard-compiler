namespace BardCompiler.Core.Models;

public sealed class SongMetadata
{
    public string Title { get; init; } = "Untitled";
    public int TicksPerQuarterNote { get; init; } = 480; // standard MIDI PPQ
    public int TempoBpm { get; init; } = 120;
}
