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
        public string character { get; set; }
        public Meaning meaning { get; set; }
        public Strokes strokes { get; set; }
        public Onyomi onyomi { get; set; }
        public Kunyomi kunyomi { get; set; }
        public Video video { get; set; }

    }

    public class Radical
    {
        public Guid Id { get; set; }
        public string character { get; set; }
        public int strokes { get; set; }
        public string image { get; set; }
        public Position position { get; set; }
        public Name name { get; set; }
        public Meaning meaning { get; set; }
        public List<Animation> animation { get; set; }
    }

    public class References
    {
        public Guid Id { get; set; }
        public short grade { get; set; }
        public short kodansha { get; set; }
        public short classicNelson { get; set; }
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
        public string opus { get; set; }
        public string aac { get; set; }
        public string ogg { get; set; }
        public string mp3 { get; set; }
    }



    public class Position
    {
        public Guid Id { get; set; }
        public string hiragana { get; set; }
        public string romaji { get; set; }
        public string icon { get; set; }
    }
    public class Name
    {
        public Guid Id { get; set; }
        public string hiragana { get; set; }
        public string romaji { get; set; }
    }
    public class Meaning
    {
        public Guid Id { get; set; }
        public string english { get; set; }
    }

    public class Strokes
    {
        public Guid Id { get; set; }
        public int count { get; set; }
        public List<Timing> timings { get; set; }
        public List<Image> images { get; set; }
    }
    public class Timing
    {
        public Guid Id { get; set; }
        public string time { get; set; }
    }

    public class Image
    {
        public Guid Id { get; set; }
        public string image { get; set; }
    }


    public class Onyomi
    {
        public Guid Id { get; set; }
        public string romaji { get; set; }
        public string katakana { get; set; }
    }

    public class Kunyomi
    {
        public Guid Id { get; set; }
        public string romaji { get; set; }
        public string hiragana { get; set; }
    }
    public class Video
    {
        public Guid Id { get; set; }
        public string poster { get; set; }
        public string mp4 { get; set; }
        public string webm { get; set; }
    }
    public class Animation
    {
        public Guid Id { get; set; }
        public string animation { get; set; }
    }

}