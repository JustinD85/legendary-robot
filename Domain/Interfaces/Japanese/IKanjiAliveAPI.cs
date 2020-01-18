namespace Application.ProjectA
{
    public interface IKanjiAliveAPI
    {
        IKanji Kanji { get; set; }
        Radical Radical { get; set; }
        References references { get; set; }
        Example[] Examples { get; set; }
    }

    public interface IKanji
    {
        string character { get; set; }
        Meaning meaning { get; set; }
        Strokes strokes { get; set; }
        Onyomi onyomi { get; set; }
        Kunyomi kunyomi { get; set; }
        Video video { get; set; }

    }

    public interface Radical
    {
        string character { get; set; }
        int strokes { get; set; }
        string image { get; set; }
        Position position { get; set; }
        Name name { get; set; }
        Meaning meaning { get; set; }
        string[] animation { get; set; }
    }

    public interface References
    {
        short grade { get; set; }
        short kodansha { get; set; }
        short classicNelson { get; set; }
    }

    public interface Example
    {
        string Japanese { get; set; }
        Meaning Meaning { get; set; }
        Audio Audio { get; set; }

    }


    public struct Audio
    {
        public string opus { get; set; }
        public string aac { get; set; }
        public string ogg { get; set; }
        public string mp3 { get; set; }
    }



    public struct Position
    {
        public string hiragana { get; set; }
        public string romaji { get; set; }
        public string icon { get; set; }
    }
    public struct Name
    {
        public string hiragana { get; set; }
        public string romaji { get; set; }
    }
    public struct Meaning
    {
        public string english { get; set; }
    }

    public struct Strokes
    {
        public int count { get; set; }
        public float[] timings { get; set; }
        public string[] images { get; set; }
    }
    public struct Onyomi
    {
        public string romaji { get; set; }
        public string katakana { get; set; }
    }

    public struct Kunyomi
    {
        public string romaji { get; set; }
        public string hiragana { get; set; }
    }
    public struct Video
    {
        public string poster { get; set; }
        public string mp4 { get; set; }
        public string webm { get; set; }
    }

}