using UnityEngine;

namespace DiscordGameSDKWrapper
{
    public static class ImageManagerExtensions
    {
        public static Texture2D GetTexture(this ImageManager manager, ImageHandle handle)
        {
            ImageDimensions dimensions = manager.GetDimensions(handle);
            Texture2D texture = new Texture2D((int)dimensions.Width, (int)dimensions.Height, TextureFormat.RGBA32, false, true);
            texture.LoadRawTextureData(manager.GetData(handle));
            texture.Apply();
            return texture;
        }
    }
}