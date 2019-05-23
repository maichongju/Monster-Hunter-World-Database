using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MonsterHunterWorld.Class
{
    public static class Utilities
    {
        public static bool Debug { get { return Options.Instance.Debug; } }

        #region SVG

        //Source https://lasithapetthawadu.wordpress.com/2014/02/24/using-vector-svg-graphics-in-c-net/
        /// <summary>
        /// Converts an SVG file to a Bitmap image.
        /// </summary>
        /// <param name="path">The full path of the SVG image.</param>
        /// <param name="width">Width of the Maximize, Default 64</param>
        /// <param name="height">Height of the Maximize, Default 64</param>
        public static Image GetImageFromSVG(string path, int width = 100, int height = 100)
        {
            Image image = null;
            Size MaximumSize = new Size(width, height);
            try
            {
                image = AdjustSize(SvgDocument.Open(path), MaximumSize).Draw();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LogWritter.Instance.Write($"GetImageFromSVG {path}", LogCategory.Error);
                LogWritter.Instance.Write(ex.Message, LogCategory.Error);
                LogWritter.Instance.Write(ex.StackTrace, LogCategory.Error);
            }
            return image;
        }

        public static Image GetImageFromSVG(string path, Size MaximumSize)
        {
            return GetImageFromSVG(path, MaximumSize.Width, MaximumSize.Height);
        }

        /// <summary>
        /// Will convert the SVG to <class>Image</class>, if the source color and destination color are the same
        /// then it won't perform the swap color
        /// </summary>
        /// <param name="path">Path for the SVG file</param>
        /// <param name="SourceColor">Source Color for swap</param>
        /// <param name="DestinColor">Destinate Color for swap </param>
        /// <param name="MaximumSize">Maximum Size for the <class>Image</class></param>
        /// <returns></returns>
        public static Image GetImageFromSVG(string path, Color SourceColor, Color DestinColor, Size MaximumSize)
        {
            // If source color and the destination color are the same then it will not perform the swap color
            if (SourceColor.ToArgb() == DestinColor.ToArgb())
            {
                return GetImageFromSVG(path, MaximumSize.Width, MaximumSize.Height);
            }
            else
            {
                return GetImageFromSVG(path, SourceColor, DestinColor, MaximumSize.Width, MaximumSize.Height);
            }
        }

        public static Image GetImageFromSVG(string path, Color sourceColor, Color DestinColor, int width = 100, int height = 100)
        {
            Image image = null;
            if (DestinColor == null || sourceColor == null)
            {
                GetImageFromSVG(path, width, height);
            }
            else
            {
                Size MaximumSize = new Size(width, height);
                try
                {
                    SvgDocument svgImage = AdjustSize(SvgDocument.Open(path), MaximumSize);
                    foreach (SvgElement item in svgImage.Children)
                    {
                        ChangeFill(item, sourceColor, DestinColor);
                    }
                    image = svgImage.Draw();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return image;
        }

        /// <summary>
        ///  Recursive fill function to change the color of a selected node and all of its children.
        /// </summary>
        /// <param name="element">The current element been resolved.</param>
        /// <param name="sourceColor">The source color to search for.</param>
        /// <param name="replaceColor">The color to be replaced the source color with.</param>
        private static void ChangeFill(SvgElement element, Color sourceColor, Color replaceColor)
        {
            if (element is SvgPath)
            {
                if (((element as SvgPath).Fill as SvgColourServer).Colour.ToArgb() == sourceColor.ToArgb())
                {
                    (element as SvgPath).Fill = new SvgColourServer(replaceColor);
                }
            }

            if (element.Children.Count > 0)
            {
                foreach (var item in element.Children)
                {
                    ChangeFill(item, sourceColor, replaceColor);
                }
            }
        }

        private static SvgDocument AdjustSize(SvgDocument document, Size MaximumSize)
        {
            if (document.Height > MaximumSize.Height)
            {
                document.Width = (int)((document.Width / (double)document.Height) * MaximumSize.Height);
                document.Height = MaximumSize.Height;
            }
            return document;
        }

        #endregion SVG

        //Source https://stackoverflow.com/questions/33853434/how-to-draw-a-rounded-rectangle-in-c-sharp
        public static GraphicsPath RoundRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();
            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc
            path.AddArc(arc, 180, 90);

            // top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        #region Skill Bar

        private static Dictionary<string, Image> SkillBarCache = new Dictionary<string, Image>();

        /// <summary>
        /// Get the Image for skill level
        /// </summary>
        /// <param name="MaxLevel"></param>
        /// <param name="Level"></param>
        /// <param name="Height"></param>
        /// <returns>Image Size [Height * 9, Height]</returns>
        public static Image GetSkillBar(int MaxLevel, int Level, int Height = 20)
        {
            string CacheKey = $"ui_skill_{MaxLevel}_{Level}_{Height}";
            if (!SkillBarCache.ContainsKey(CacheKey))
            {
                Image tempImage = SkillBarHelp(MaxLevel, Level, Height);
                SkillBarCache.Add(CacheKey, tempImage);
            }
            return SkillBarCache[CacheKey];
        }

        private static Image SkillBarHelp(int MaxLevel, int Level, int Height)
        {
            Bitmap bm = new Bitmap(Height * (7 + 2), Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                Size BlockSize = new Size(Height, Height);
                int x = 0;
                Image LeftImage = GetImage("ui_skill_left", BlockSize);
                g.DrawImage(LeftImage, x, 0);
                x += Height;
                int index = 0;
                //Add fill
                while (index < Level)
                {
                    index++;
                    g.DrawImage(GetImage("ui_skill_filled", BlockSize), index * Height, 0);
                }
                while (index < MaxLevel)
                {
                    index++;
                    g.DrawImage(GetImage("ui_skill_empty", BlockSize), index * Height, 0);
                }
                while (index < 8)
                {
                    index++;
                    g.DrawImage(GetImage("ui_skill_space", BlockSize), index * Height, 0);
                }
                g.DrawImage(GetImage("ui_skill_right", BlockSize), (index) * Height, 0);
            }
            return bm;
        }

        #endregion Skill Bar

        #region Cached Image

        /// <summary>
        /// Image Key format: Image_name_width_height
        /// </summary>
        public static Dictionary<string, Image> CacheImage = new Dictionary<string, Image>();

        /// <summary>
        /// Get Image, find it on the Cache Image first, if can not find then get it from SVG
        /// </summary>
        /// <param name="ImageName"></param>
        /// <returns></returns>
        public static Image GetImage(string ImageName)
        {
            string ImageKey = ImageName;
            if (!CacheImage.ContainsKey(ImageKey))
            {
                Image image = Utilities.GetImageFromSVG(Properties.Resources.ResourceManager.GetString(ImageKey));
                //Image equal null means can not find the image
                if (image == null)
                {
                    LogWritter.Instance.Write($"{ImageKey} can not be found", LogCategory.Error);
                }
                CacheImage.Add(ImageKey, image);
            }
            return new Bitmap(CacheImage[ImageKey]);
        }

        /// <summary>
        /// This is for Weapon Melody Only!
        /// </summary>
        /// <param name="ImageName"></param>
        /// <param name="color"></param>
        /// <param name="ImageSize"></param>
        /// <returns></returns>
        public static Image GetImage(string ImageName, Char color, Size ImageSize)
        {
            string ImageKey = $"{ImageName}_{color}_{ImageSize.Width}_{ImageSize.Height}";
            if (!CacheImage.ContainsKey(ImageKey))
            {
                Image image = Utilities.GetImageFromSVG(Properties.Resources.ResourceManager.GetString(ImageName), Color.White, MonsterHunterColor.MelodyColor[color], ImageSize);
                //Image equal null means can not find the image
                if (image == null)
                {
                    LogWritter.Instance.Write($"{ImageKey} can not be found", LogCategory.Error);
                }
                CacheImage.Add(ImageKey, image);
            }
            return new Bitmap(CacheImage[ImageKey]);
        }

        /// <summary>
        /// Get the image with the given size
        /// </summary>
        /// <param name="ImageName"></param>
        /// <param name="ImageSize"></param>
        /// <returns></returns>
        public static Image GetImage(string ImageName, Size ImageSize)
        {
            string ImageKey = $"{ImageName}_{ImageSize.Width}_{ImageSize.Height}";
            if (!CacheImage.ContainsKey(ImageKey))
            {
                Image image = Utilities.GetImageFromSVG(Properties.Resources.ResourceManager.GetString(ImageName), ImageSize.Width, ImageSize.Height);
                //Image equal null means can not find the image
                if (image == null)
                {
                    LogWritter.Instance.Write($"{ImageKey} can not be found", LogCategory.Error);
                }
                CacheImage.Add(ImageKey, image);
            }
            return new Bitmap(CacheImage[ImageKey]);
        }

        /// <summary>
        /// Get the Image with the given size and replace the color
        /// </summary>
        /// <param name="ImageName">Image name for SVG file</param>
        /// <param name="SourceColor">Color need to replace</param>
        /// <param name="DestinColor">Color replace to</param>
        /// <param name="size">Size of the image</param>
        /// <returns></returns>
        public static Image GetImage(string ImageName, Color SourceColor, Color DestinColor, Size size)
        {
            string ImageKey = $"{ImageName}_{SourceColor.Name}_{DestinColor.Name}_{size.Width}_{size.Height}";//TODO
            if (!CacheImage.ContainsKey(ImageKey))
            {
                Image image = Utilities.GetImageFromSVG(Properties.Resources.ResourceManager.GetString(ImageName), SourceColor, DestinColor, size);
                //Image equal null means can not find the image
                if (image == null)
                {
                    LogWritter.Instance.Write($"{ImageKey} can not be found", LogCategory.Error);
                }
                CacheImage.Add(ImageKey, image);
            }
            return CacheImage[ImageKey];
        }

        public static Image GetImage(string ImageName, Color SourceColor, Color DestinColor)
        {
            string ImageKey = $"{ImageName}_{SourceColor.Name}_{DestinColor.Name}";
            if (!CacheImage.ContainsKey(ImageKey))
            {
                Image image = Utilities.GetImageFromSVG(Properties.Resources.ResourceManager.GetString(ImageName), SourceColor, DestinColor);
                //Image equal null means can not find the image
                if (image == null)
                {
                    LogWritter.Instance.Write($"{ImageKey} can not be found", LogCategory.Error);
                }
                CacheImage.Add(ImageKey, image);
            }
            return CacheImage[ImageKey];
        }
    }

    #endregion Cached Image
}