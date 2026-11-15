using System;
using System.Collections.Generic;
using System.Text;

namespace LaseryKraszery
{
    internal static class GameSettings
    {
        public static bool SoundEnabled { get; set; } = true;
        public static int SelectedLevel { get; set; } = 1;
        public const int LevelCount = 5;
    }
}