namespace BardCompiler.Core.Models;

public sealed class Song
{
    public SongMetadata Metadata { get; }
    public List<Track> Tracks { get; } = new();

    public Song(SongMetadata metadata)
    {
        Metadata = metadata;
    }

    public Track? GetTrack(string name) =>
        Tracks.FirstOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    public Track GetOrCreateTrack(string name, Func<Track> factory)
    {
        var existing = GetTrack(name);
        if (existing is not null) return existing;

        var created = factory();
        Tracks.Add(created);
        return created;
    }
}
