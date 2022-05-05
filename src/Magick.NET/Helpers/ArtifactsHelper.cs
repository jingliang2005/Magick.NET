﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System.Globalization;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
    internal class ArtifactsHelper
    {
        public static void SetImageArtifacts(IMagickImage<QuantumType> image, ICompareSettings<QuantumType> settings)
        {
            if (settings.HighlightColor is not null)
                image.SetArtifact("compare:highlight-color", settings.HighlightColor.ToString());

            if (settings.LowlightColor is not null)
                image.SetArtifact("compare:lowlight-color", settings.LowlightColor.ToString());

            if (settings.MasklightColor is not null)
                image.SetArtifact("compare:masklight-color", settings.MasklightColor.ToString());
        }

        public static void RemoveImageArtifacts(IMagickImage<QuantumType> image, ICompareSettings<QuantumType> settings)
        {
            if (settings.HighlightColor is not null)
                image.RemoveArtifact("compare:highlight-color");

            if (settings.LowlightColor is not null)
                image.RemoveArtifact("compare:lowlight-color");

            if (settings.MasklightColor is not null)
                image.RemoveArtifact("compare:masklight-color");
        }

        public static void SetImageArtifacts(IMagickImage<QuantumType> image, IComplexSettings settings)
        {
            if (settings.SignalToNoiseRatio is not null)
                image.SetArtifact("complex:snr", settings.SignalToNoiseRatio.Value.ToString(CultureInfo.InvariantCulture));
        }

        public static void RemoveImageArtifacts(IMagickImage<QuantumType> image, IComplexSettings self)
        {
            if (self.SignalToNoiseRatio is not null)
                image.RemoveArtifact("complex:snr");
        }

        public static void SetImageArtifacts(IMagickImage<QuantumType> image, IConnectedComponentsSettings settings)
        {
            if (settings.AngleThreshold is not null)
                image.SetArtifact("connected-components:angle-threshold", settings.AngleThreshold.Value.ToString());

            if (settings.AreaThreshold is not null)
                image.SetArtifact("connected-components:area-threshold", settings.AreaThreshold.Value.ToString());

            if (settings.CircularityThreshold is not null)
                image.SetArtifact("connected-components:circularity-threshold", settings.CircularityThreshold.Value.ToString());

            if (settings.DiameterThreshold is not null)
                image.SetArtifact("connected-components:diameter-threshold", settings.DiameterThreshold.Value.ToString());

            if (settings.EccentricityThreshold is not null)
                image.SetArtifact("connected-components:eccentricity-threshold", settings.EccentricityThreshold.Value.ToString());

            if (settings.MajorAxisThreshold is not null)
                image.SetArtifact("connected-components:major-axis-threshold", settings.MajorAxisThreshold.Value.ToString());

            if (settings.MeanColor)
                image.SetArtifact("connected-components:mean-color", settings.MeanColor);

            if (settings.MinorAxisThreshold is not null)
                image.SetArtifact("connected-components:minor-axis-threshold", settings.MinorAxisThreshold.Value.ToString());

            if (settings.PerimeterThreshold is not null)
                image.SetArtifact("connected-components:perimeter-threshold", settings.PerimeterThreshold.Value.ToString());
        }

        public static void RemoveImageArtifacts(IMagickImage<QuantumType> image, IConnectedComponentsSettings settings)
        {
            if (settings.AngleThreshold is not null)
                image.RemoveArtifact("connected-components:angle-threshold");

            if (settings.AreaThreshold is not null)
                image.RemoveArtifact("connected-components:area-threshold");

            if (settings.CircularityThreshold is not null)
                image.RemoveArtifact("connected-components:circularity-threshold");

            if (settings.DiameterThreshold is not null)
                image.RemoveArtifact("connected-components:diameter-threshold");

            if (settings.EccentricityThreshold is not null)
                image.RemoveArtifact("connected-components:eccentricity-threshold");

            if (settings.MajorAxisThreshold is not null)
                image.RemoveArtifact("connected-components:major-axis-threshold");

            if (settings.MeanColor)
                image.RemoveArtifact("connected-components:mean-color");

            if (settings.MinorAxisThreshold is not null)
                image.RemoveArtifact("connected-components:minor-axis-threshold");

            if (settings.PerimeterThreshold is not null)
                image.RemoveArtifact("connected-components:perimeter-threshold");
        }

        public static void SetImageArtifacts(IMagickImage<QuantumType> image, IDeskewSettings settings)
        {
            if (settings.AutoCrop)
                image.SetArtifact("deskew:auto-crop", settings.AutoCrop);
        }

        public static void RemoveImageArtifacts(IMagickImage<QuantumType> image, IDeskewSettings settings)
        {
            if (settings.AutoCrop)
                image.RemoveArtifact("deskew:auto-crop");
        }

        public static void SetImageArtifacts(IMagickImage<QuantumType> image, IDistortSettings settings)
        {
            if (settings.Scale is not null)
                image.SetArtifact("distort:scale", settings.Scale.Value.ToString(CultureInfo.InvariantCulture));

            if (settings.Viewport is not null)
                image.SetArtifact("distort:viewport", settings.Viewport.ToString());
        }

        public static void RemoveImageArtifacts(IMagickImage<QuantumType> image, IDistortSettings settings)
        {
            if (settings.Scale is not null)
                image.RemoveArtifact("distort:scale");

            if (settings.Viewport is not null)
                image.RemoveArtifact("distort:viewport");
        }

        public static void SetImageArtifacts(IMagickImage<QuantumType> image, IKmeansSettings settings)
        {
            if (settings.SeedColors is not null && settings.SeedColors.Length > 0)
                image.SetArtifact("kmeans:seed-colors", settings.SeedColors);
        }

        public static void RemoveImageArtifacts(IMagickImage<QuantumType> image, IKmeansSettings settings)
        {
            if (!string.IsNullOrEmpty(settings.SeedColors))
                image.RemoveArtifact("kmeans:seed-colors");
        }

        public static void SetImageArtifacts(IMagickImage<QuantumType> image, IMorphologySettings settings)
        {
            if (settings.ConvolveBias is not null)
                image.SetArtifact("convolve:bias", settings.ConvolveBias.ToString());

            if (settings.ConvolveScale is not null)
                image.SetArtifact("convolve:scale", settings.ConvolveScale.ToString());
        }

        public static void RemoveImageArtifacts(IMagickImage<QuantumType> image, IMorphologySettings settings)
        {
            if (settings.ConvolveBias is not null)
                image.RemoveArtifact("convolve:bias");

            if (settings.ConvolveScale is not null)
                image.RemoveArtifact("convolve:scale");
        }
    }
}
