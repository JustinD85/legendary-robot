using System;
using System.Collections.Generic;
using Domain.Interfaces.Japanese;

namespace Domain.Concrete.KanjiAliveAPI
{
    public class KanjiAliveAPI : IKanjiAliveAPI
    {
        public Guid Id { get; set; }
        public Kanji Kanji { get; set; }
        public Radical Radical { get; set; }
        public References References { get; set; }
        public List<Example> Examples { get; set; }
    }
}