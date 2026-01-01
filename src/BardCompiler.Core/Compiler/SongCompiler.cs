using BardCompiler.Core.Models;
using BardCompiler.Core.Models.Enums;
using BardCompiler.Core.Models.Events;

namespace BardCompiler.Core.Compiler;

public sealed class SongCompiler
{
    public Song Compile(Song input)
    {
        // Clone metadata (we may mutate later)
        var song = new Song(input.Metadata);

        // Copy tracks
        foreach (var track in input.Tracks)
        {
            song.Tracks.Add(track);
        }

        EnsureSoloTrack(song);

        return song;
    }

    private static void EnsureSoloTrack(Song song)
    {
        song.GetOrCreateTrack(
            "Solo",
            () => new Track(
                name: "Solo",
                instrument: Instrument.OverdrivenGuitar
            )
        );
    }
}
