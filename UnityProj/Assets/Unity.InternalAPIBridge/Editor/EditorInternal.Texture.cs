using UnityEditor;
using UnityEngine;

public static partial class EditorInternal
{
    public static long GetStorageMemorySizeLong(this Texture texture)
    {
        return TextureUtil.GetStorageMemorySizeLong(texture);
    }

    public static long GetRuntimeMemorySizeLong(this Texture texture)
    {
        return TextureUtil.GetRuntimeMemorySizeLong(texture);
    }

    public static TextureFormat GetTextureFormat(this Texture texture)
    {
        return TextureUtil.GetTextureFormat(texture);
    }

    public static bool IsNonPowerOfTwo(this Texture2D texture)
    {
        return TextureUtil.IsNonPowerOfTwo(texture);
    }

    public static bool IsValidTextureFormat(TextureFormat format)
    {
        return TextureUtil.IsValidTextureFormat(format);
    }

    public static bool IsCompressedTextureFormat(TextureFormat format)
    {
        return TextureUtil.IsCompressedTextureFormat(format);
    }

    public static bool IsCompressedCrunchTextureFormat(TextureFormat format)
    {
        return TextureUtil.IsCompressedCrunchTextureFormat(format);
    }
}
