using System;
using System.Collections.Generic;

namespace Domain.Interfaces.Japanese
{
    public interface IKanjiAliveAPI
    {
        Kanji Kanji { get; set; }
        Radical Radical { get; set; }
        References References { get; set; }
        List<Example> Examples { get; set; }
    }

    public class Kanji
    {
        public Guid Id { get; set; }
        public string Character { get; set; }
        public Meaning Meaning { get; set; }
        public Strokes Strokes { get; set; }
        public Onyomi Onyomi { get; set; }
        public Kunyomi Kunyomi { get; set; }
        public Video Video { get; set; }

    }

    public class Radical
    {
        public Guid Id { get; set; }
        public string Character { get; set; }
        public int Strokes { get; set; }
        public string Image { get; set; }
        public Position Position { get; set; }
        public Name Name { get; set; }
        public Meaning Meaning { get; set; }
        public List<Animation> Animation { get; set; }
    }

    public class References
    {
        public Guid Id { get; set; }
        public short Grade { get; set; }
        public short Kodansha { get; set; }
        public short ClassicNelson { get; set; }
    }

    public class Example
    {
        public Guid Id { get; set; }
        public string Japanese { get; set; }
        public Meaning Meaning { get; set; }
        public Audio Audio { get; set; }

    }


    public class Audio
    {
        public Guid Id { get; set; }
        public string Opus { get; set; }
        public string Aac { get; set; }
        public string Ogg { get; set; }
        public string Mp3 { get; set; }
    }



    public class Position
    {
        public Guid Id { get; set; }
        public string Hiragana { get; set; }
        public string Romaji { get; set; }
        public string Icon { get; set; }
    }
    public class Name
    {
        public Guid Id { get; set; }
        public string Hiragana { get; set; }
        public string Romaji { get; set; }
    }
    public class Meaning
    {
        public Guid Id { get; set; }
        public string English { get; set; }
    }

    public class Strokes
    {
        public Guid Id { get; set; }
        public int Count { get; set; }
        public List<Timing> Timings { get; set; }
        public List<Image> Images { get; set; }
    }
    public class Timing
    {
        public Guid Id { get; set; }
        public string Time { get; set; }
    }

    public class Image
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
    }


    public class Onyomi
    {
        public Guid Id { get; set; }
        public string Romaji { get; set; }
        public string Katakana { get; set; }
    }

    public class Kunyomi
    {
        public Guid Id { get; set; }
        public string Romaji { get; set; }
        public string Hiragana { get; set; }
    }
    public class Video
    {
        public Guid Id { get; set; }
        public string Poster { get; set; }
        public string Mp4 { get; set; }
        public string Webm { get; set; }
    }
    public class Animation
    {
        public Guid Id { get; set; }
        public string SVG { get; set; }
    }

}