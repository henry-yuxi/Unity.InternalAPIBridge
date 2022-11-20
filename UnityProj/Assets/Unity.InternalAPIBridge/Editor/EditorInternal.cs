using UnityEditor;
using UnityEngine;

public static partial class EditorInternal
{
    public static long GetRuntimeMemorySizeLong(this Texture texture)
    {
        return TextureUtil.GetRuntimeMemorySizeLong(texture);
    }

    public static PropertyModification ExtractPropertyModification(this SerializedObject serializedObject, string propertyPath)
    {
        return serializedObject.ExtractPropertyModification(propertyPath);
    }
}
