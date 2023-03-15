using Aquality.Appium.Mobile.Applications;
using Aquality.Selenium.Core.Visualization;
using SkiaSharp;
using System;
using System.IO;

namespace Aquality.Appium.Mobile.Template.Utilities
{
    public class ScreenshotProvider : IScreenshotProvider
    {
        public string TakeScreenshot()
        {
            var image = GetImage();
            var directory = Path.Combine(Environment.CurrentDirectory, "screenshots");
            EnsureDirectoryExists(directory);
            var screenshotName = $"{GetType().Name}_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString("n").Substring(0, 5)}.png";
            var path = Path.Combine(directory, screenshotName);
            image.Save(path, SKEncodedImageFormat.Png);
            return path;
        }

        private static SKImage GetImage()
        {
            return AqualityServices.Application.Driver.GetScreenshot().AsImage();
        }

        private static void EnsureDirectoryExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
