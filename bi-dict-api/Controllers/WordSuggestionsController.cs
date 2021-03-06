﻿using bi_dict_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace bi_dict_api.Controllers
{
    using Utils.WordSuggestionsProvider;

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class WordSuggestionsController : ControllerBase
    {
        private readonly IHttpClientFactory clientFactory;

        public WordSuggestionsController(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        [HttpGet("{word}/{language}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<WordSuggestion>>> Get(string word, string language)
        {
            try
            {
                var suggestions = await WordSuggestionsProviderFactory.Create(clientFactory, language).Get(word);
                return Ok(suggestions);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return NotFound();
            }
        }
    }
}