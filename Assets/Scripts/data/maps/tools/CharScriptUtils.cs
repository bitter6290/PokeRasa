#if UNITY_EDITOR
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class CharScriptUtils
{
    public static List<System.Type> GetAllCharScripts
    {
        get
        {
            List<System.Type> charScripts = new();
            foreach (System.Type T in typeof(CharScripts).Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(CharScripts)) && !t.IsAbstract))
            {
                charScripts.Add(T);
            }
            return charScripts;
        }
    }
    public static string TypeToName(System.Type T) => T.Namespace + '.' + T.Name;
    public static string NameToPath(string name)
    {
        string[] splitString = name.Split('.');
        (splitString[1], splitString[0]) = (splitString[0], splitString[1]);
        return "Assets/MapScripts/" + string.Join('/', splitString) + ".asset";

    }

    public static string PathToDirectory(string path)
    {
        string[] splitString = path.Split('/');
        return string.Join('/', splitString.SkipLast(1));
    }

    public static string TypeToPath(this System.Type T) => NameToPath(TypeToName(T));
    [MenuItem("Services/NameTest")]
    public static void NameTest()
    {
        foreach (System.Type T in GetAllCharScripts)
        {
            Debug.Log(NameToPath(TypeToName(T)));
        }
    }
    [MenuItem("Services/Create Missing Scripts")]
    public static void CreateMissingScripts()
    {
        foreach (System.Type T in GetAllCharScripts)
        {
            string newPath = T.TypeToPath();
            if (!AssetDatabase.LoadAssetAtPath<CharScripts>(newPath))
            {
                var newObject = ScriptableObject.CreateInstance(T);
                if (!Directory.Exists(PathToDirectory(newPath)))
                    _ = Directory.CreateDirectory(PathToDirectory(newPath));
                AssetDatabase.CreateAsset(newObject, T.TypeToPath());
            }
        }
    }
}

#endif