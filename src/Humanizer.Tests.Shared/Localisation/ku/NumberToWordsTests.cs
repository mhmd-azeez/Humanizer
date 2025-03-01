﻿using Xunit;

namespace Humanizer.Tests.Localisation.ku
{
    [UseCulture("ku")]
    public class NumberToWordsTests
    {
        [Theory]
        [InlineData(-1, "نێگەتیڤ یەک")]
        [InlineData(-10, "نێگەتیڤ دە")]
        [InlineData(-100, "نێگەتیڤ سەد")]
        [InlineData(-999, "نێگەتیڤ نۆ سەد و نەوەد و نۆ")]
        [InlineData(-1000, "نێگەتیڤ هەزار")]
        [InlineData(-1000000, "نێگەتیڤ یەک میلیۆن")]
        [InlineData(1, "یەک")]
        [InlineData(10, "دە")]
        [InlineData(11, "یازدە")]
        [InlineData(122, "سەد و بیست و دوو")]
        [InlineData(3501, "سێ هەزار و پێنج سەد و یەک")]
        [InlineData(100, "سەد")]
        [InlineData(1000, "هەزار")]
        [InlineData(100000, "سەد هەزار")]
        [InlineData(1000000, "یەک میلیۆن")]
        [InlineData(10000000, "دە میلیۆن")]
        [InlineData(100000000, "سەد میلیۆن")]
        [InlineData(1000000000, "یەک میلیارد")]
        [InlineData(111, "سەد و یازدە")]
        [InlineData(1111, "هەزار و سەد و یازدە")]
        [InlineData(111111, "سەد و یازدە هەزار و سەد و یازدە")]
        [InlineData(1001001, "یەک میلیۆن و هەزار و یەک")]
        [InlineData(1111111, "یەک میلیۆن و سەد و یازدە هەزار و سەد و یازدە")]
        [InlineData(11111111, "یازدە میلیۆن و سەد و یازدە هەزار و سەد و یازدە")]
        [InlineData(111111111, "سەد و یازدە میلیۆن و سەد و یازدە هەزار و سەد و یازدە")]
        [InlineData(1111111111, "یەک میلیارد و سەد و یازدە میلیۆن و سەد و یازدە هەزار و سەد و یازدە")]
        [InlineData(123, "سەد و بیست و سێ")]
        [InlineData(1234, "هەزار و دوو سەد و سی و چوار")]
        [InlineData(12345, "دوازدە هەزار و سێ سەد و چل و پێنج")]
        [InlineData(123456, "سەد و بیست و سێ هەزار و چوار سەد و پەنجا و شەش")]
        [InlineData(1234567, "یەک میلیۆن و دوو سەد و سی و چوار هەزار و پێنج سەد و شەست و حەوت")]
        [InlineData(12345678, "دوازدە میلیۆن و سێ سەد و چل و پێنج هەزار و شەش سەد و حەفتا و هەشت")]
        [InlineData(123456789, "سەد و بیست و سێ میلیۆن و چوار سەد و پەنجا و شەش هەزار و حەوت سەد و هەشتا و نۆ")]
        [InlineData(1234567890, "یەک میلیارد و دوو سەد و سی و چوار میلیۆن و پێنج سەد و شەست و حەوت هەزار و هەشت سەد و نەوەد")]
        public void ToWordsKurdish(int number, string expected)
        {
            Assert.Equal(expected, number.ToWords());
        }

        [Theory]
        [InlineData(0, "سفرەم")]
        [InlineData(1, "یەکەم")]
        [InlineData(2, "دووەم")]
        [InlineData(3, "سێیەم")]
        [InlineData(4, "چوارەم")]
        [InlineData(5, "پێنجەم")]
        [InlineData(6, "شەشەم")]
        [InlineData(7, "حەوتەم")]
        [InlineData(8, "هەشتەم")]
        [InlineData(9, "نۆیەم")]
        [InlineData(10, "دەیەم")]
        [InlineData(11, "یازدەیەم")]
        [InlineData(12, "دوازدەیەم")]
        [InlineData(13, "سێزدەیەم")]
        [InlineData(21, "بیست و یەکەم")]
        [InlineData(22, "بیست و دووەم")]
        [InlineData(23, "بیست و سێیەم")]
        [InlineData(24, "بیست و چوارەم")]
        [InlineData(25, "بیست و پێنجەم")]
        [InlineData(30, "سییەم")]
        [InlineData(40, "چلەم")]
        [InlineData(50, "پەنجایەم")]
        [InlineData(60, "شەستەم")]
        [InlineData(70, "حەفتایەم")]
        [InlineData(80, "هەشتایەم")]
        [InlineData(90, "نەوەدەم")]
        [InlineData(100, "سەدەم")]
        [InlineData(200, "دوو سەدەم")]
        [InlineData(1000, "هەزارەم")]
        [InlineData(1001, "هەزار و یەکەم")]
        [InlineData(1333, "هەزار و سێ سەد و سی و سێیەم")]
        [InlineData(1000000, "یەک میلیۆنەم")]
        public void ToOrdinalWordsKurdish(int number, string words)
        {
            Assert.Equal(words, number.ToOrdinalWords());
        }
    }
}
