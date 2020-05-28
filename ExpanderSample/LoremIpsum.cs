using System;

namespace ExpanderSample
{
    static class LoremIpsum
    {
        const string _loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum ";

        static readonly Random _random = new Random((int)DateTime.Now.Ticks);

        public static string GenerateText(in int? textLength = null)
        {
            var startIndex = _random.Next(_loremIpsum.Length / 2);
            var length = textLength ?? _random.Next(_loremIpsum.Length - 1 - startIndex);

            return _loremIpsum.Substring(startIndex, length);
        }
    }
}
