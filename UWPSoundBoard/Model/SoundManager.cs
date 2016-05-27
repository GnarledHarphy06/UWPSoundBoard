using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            // some changes here by Giovan
            // get rid of allsounds var
            sounds.Clear();
            getSounds().ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory category)
        {
            // some changes here by Giovan
            // get rid of allsounds var
            sounds.Clear();
            var filteredSounds = getSounds().Where(p => p.Category == category).ToList();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByName(ObservableCollection<Sound> sounds, string name)
        {
            // made some changes here too
            sounds.Clear();
            var filteredSounds = getSounds().Where(p => p.Name == name).ToList();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Model.Sound("Cat", SoundCategory.Animals));
            sounds.Add(new Model.Sound("Cow", SoundCategory.Animals));

            sounds.Add(new Model.Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Model.Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Model.Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Model.Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Model.Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Model.Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }
    }
}
