﻿namespace bi_dict_api.Utils.DefinitionProvider.WiktionaryParser
{
    using HtmlAgilityPack;
    using Models;
    using System.Collections.Generic;

    public interface IWikiEtymologyParser
    {

        public IEnumerable<EtymologySection> Parse(HtmlNode LanguageSection);
    }
}