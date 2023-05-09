﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick;
using Xunit;

namespace Magick.NET.Tests;

public partial class MagickImageTests
{
    public class TheMeanShiftMethod
    {
        [Fact]
        public void ShouldNotChangeImageWhenSizeIsOne()
        {
            using (var input = new MagickImage(Files.FujiFilmFinePixS1ProPNG))
            {
                using (var output = input.Clone())
                {
                    output.MeanShift(1);

                    Assert.Equal(0.0, output.Compare(input, ErrorMetric.RootMeanSquared));
                }
            }
        }

        [Fact]
        public void ShouldChangeImage()
        {
            using (var input = new MagickImage(Files.FujiFilmFinePixS1ProPNG))
            {
                using (var output = input.Clone())
                {
                    output.MeanShift(2, new Percentage(80));

                    Assert.InRange(output.Compare(input, ErrorMetric.RootMeanSquared), 0.019, 0.020);
                }
            }
        }
    }
}
