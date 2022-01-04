using AngleSharp.Dom;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using YoutubeExplode.Utils;
using YoutubeExplode.Utils.Extensions;

namespace YoutubeExplode.Bridge.Extractors
{
    internal class RelatedVideosExtractor
    {
        private readonly Memo _memo = new();

        public IElement _content { get; }



        public RelatedVideosExtractor(IElement element)
        {
            _content = element;
        }

        public string? TryGetTitle() => _memo.Wrap(() =>
            _content.QuerySelector("#video-title").NodeValue
        );

    }
}