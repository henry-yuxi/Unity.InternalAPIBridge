using UnityEditor;
using UnityEngine;

public static partial class EditorInternal
{
    public static string[] GetAllGlobalKeywords()
    {
        return ShaderUtil.GetAllGlobalKeywords();
    }

    public static string[] GetShaderGlobalKeywords(this Shader shader)
    {
        return ShaderUtil.GetShaderGlobalKeywords(shader);
    }

    public static string[] GetShaderLocalKeywords(this Shader shader)
    {
        return ShaderUtil.GetShaderLocalKeywords(shader);
    }

    public static ShaderData GetShaderData(this Shader shader)
    {
        return ShaderUtil.GetShaderData(shader);
    }
}
