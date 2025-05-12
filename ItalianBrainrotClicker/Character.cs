using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Maui.Audio;

namespace ItalianBrainrotClicker
{
    internal record Character(String srcSound, String srcImage)
    {
        public Stream sound = FileSystem.OpenAppPackageFileAsync(srcSound).Result;
    }
}
