using UnityEngine;

public static class Extend_TransformHelpers
{
    public static Transform FindChildByName(this Transform transform, string name)
    {
        Transform[] transforms = transform.GetComponentsInChildren<Transform>();

        foreach (Transform t in transforms)
        {
            if (t.name.Equals(name))
                return t;
        }

        return null;
    }
}

#if UNITY_EDITOR
public static class DirectoryHelpers
{
    public static void ToRelativePath(ref string absolutePath)
    {
        int start = absolutePath.IndexOf("/Assets/");
        Debug.Assert(start > 0, "올바른 에셋 경로 아님");

        absolutePath = absolutePath.Substring(start + 1, absolutePath.Length - start - 1);
    }
}

public static class FileHelpers
{
    public static string GetFileName(string assetPath)
    {
        Debug.Assert(assetPath.Length > 0, "올바른 에셋 경로 아님");

        int end = assetPath.LastIndexOf('/');

        return assetPath.Substring(end + 1, assetPath.Length - end - 1);
    }
}
#endif