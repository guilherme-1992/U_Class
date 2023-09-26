using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProjectUtils
{

    

#if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Test")]
    public static void Test()
    {
        Debug.Log("Test");
    }

    [UnityEditor.MenuItem("Ebac/Criar obj %g")]
    public static void CreaterObj()
    {
        GameObject go = new GameObject("Objeto");
    }
#endif

    public static T GetRandom<T>(this List<T> list)
    {
        return list [Random.Range(0, list.Count)];
    }

    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale  = Vector3. one * size;
    }


}
