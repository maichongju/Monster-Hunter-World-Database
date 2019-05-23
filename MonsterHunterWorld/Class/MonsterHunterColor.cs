using System.Collections.Generic;
using System.Drawing;

namespace MonsterHunterWorld.Class
{
    internal class MonsterHunterColor
    {
        public static Color R1 = Color.FromArgb(180, 181, 178);
        public static Color R2 = Color.FromArgb(176, 184, 176);
        public static Color R3 = Color.FromArgb(162, 187, 41);
        public static Color R4 = Color.FromArgb(73, 178, 71);
        public static Color R5 = Color.FromArgb(76, 152, 159);
        public static Color R6 = Color.FromArgb(87, 92, 215);
        public static Color R7 = Color.FromArgb(146, 88, 219);
        public static Color R8 = Color.FromArgb(214, 119, 80);

        public static Color SRed = Color.Red;
        public static Color SOrange = Color.Orange;
        public static Color SYellow = Color.Yellow;
        public static Color SGreen = Color.LawnGreen;
        public static Color SBlue = Color.DeepSkyBlue;
        public static Color SWhite = Color.White;
        public static Color SNone = Color.SlateGray;

        public static Color LISTBOXBACKGROUND = Color.FromArgb(79, 81, 93);
        public static Color UIARMORBASE = Color.FromArgb(202, 200, 198);

        public static Color Fire = Color.FromArgb(211, 59, 0);
        public static Color Water = Color.FromArgb(90, 196, 235);
        public static Color Thunder = Color.FromArgb(201, 188, 29);
        public static Color Ice = Color.FromArgb(56, 96, 159);
        public static Color Dragon = Color.FromArgb(83, 64, 121);

        public static List<Color> RarityColor { get; }
        public static Dictionary<string, Color> IconColor { get; }
        public static List<Color> SharpnessColor { get; }
        public static Dictionary<char, Color> MelodyColor { get; }
        public static Dictionary<string, Color> ElementColor { get; }

        static MonsterHunterColor()
        {
            RarityColor = new List<Color>() { R1, R2, R3, R4, R5, R6, R7, R8 };
            SharpnessColor = new List<Color>() { SRed, SOrange, SYellow, SGreen, SBlue, SWhite, SNone };
            IconColor = new Dictionary<string, Color>
            {
                { "darkpurple", Color.FromArgb(212, 177, 19) },
                { "lime", Color.FromArgb(150, 195, 63) },
                { "orange", Color.FromArgb(207, 105, 65) },
                { "darkred", Color.FromArgb(152, 22, 65) },
                { "blue", Color.FromArgb(111, 142, 237) },
                { "darkbeige", Color.FromArgb(218, 179, 130) },
                { "lightbeige", Color.FromArgb(236, 212, 154) },
                { "darkgreen", Color.FromArgb(61, 121, 54) },
                { "gold", Color.FromArgb(192, 162, 21) },
                { "gray", Color.FromArgb(202, 201, 201) },
                { "beige",Color.FromArgb(242, 174, 108) },
                { "white", Color.Snow},
                { "violet", Color.FromArgb(174, 159, 244) },
                { "cyan", Color.FromArgb(162, 226, 208) },
                { "yellow", Color.FromArgb(201, 218, 4) },
                { "pink", Color.FromArgb(219,112,147)},
                { "green", Color.FromArgb(83, 185, 159)},
                { "red", Color.FromArgb( 231, 86, 105)},
                {"",Color.White } };
            MelodyColor = new Dictionary<char, Color>
            {
                {'P',Color.MediumPurple },
                {'W',Color.White },
                {'R',Color.IndianRed },
                {'Y',Color.Yellow },
                {'B',Color.DodgerBlue },
                {'C',Color.Cyan },
                {'O',Color.Orange },
                {'G',Color.LightGreen }
            };
            ElementColor = new Dictionary<string, Color>
            {
                {"fire",Fire },
                {"water",Water },
                {"thunder",Thunder },
                {"ice",Ice },
                {"dragon",Dragon }
            };
        }
    }
}