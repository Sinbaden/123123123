using UnityEngine;

namespace Assets.project.Scripts.Common
{
    public class ImageLoader
    {
        private static string uiPath = "Images/UI/";

        public static Sprite LoadUIImage(string path) => Resources.Load<Sprite>(uiPath + path);
    }
}
