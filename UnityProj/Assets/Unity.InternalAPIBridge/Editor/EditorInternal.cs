using UnityEditor;

public static partial class EditorInternal
{
    public static PropertyModification ExtractPropertyModification(this SerializedObject serializedObject, string propertyPath)
    {
        return serializedObject.ExtractPropertyModification(propertyPath);
    }
}
