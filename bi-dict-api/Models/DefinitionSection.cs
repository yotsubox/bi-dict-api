﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bi_dict_api.Models {

    public class DefinitionSection {
        public string Definition { get; set; }
        public IEnumerable<string> Examples { get; set; }
        public IEnumerable<string> Synonyms { get; set; }
        public IEnumerable<string> Antonyms { get; set; }

        public IEnumerable<DefinitionSection> SubDefinitions { get; set; }
    }
}