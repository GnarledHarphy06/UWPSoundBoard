using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = $"/Assets/Audio/{Category}/{Name}.wav";
            ImageFile = $"/Assets/Images/{Category}/{Name}.png";
        }
    }

    public enum SoundCategory { Animals, Cartoons, Taunts, Warnings}
}
