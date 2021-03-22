﻿using System.Collections.Generic;

namespace bi_dict_api.Models
{

    public class EtymologyInnerSection
    {
        public string PartOfSpeech { get; set; } = default!;
        public string Meaning { get; set; } = default!;
        public string Inflection { get; set; } = default!;
        public IEnumerable<string> Synonyms { get; set; } = default!;
        public IEnumerable<string> Antonyms { get; set; } = default!;
        public IEnumerable<Subsense> SubSenses { get; set; } = default!;
    }
}