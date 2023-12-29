#if UNITY_EDITOR
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class MapAndObjectScriptUtils
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
    public static List<System.Type> GetAllMapScripts
    {
        get
        {
            List<System.Type> charScripts = new();
            foreach (System.Type T in typeof(MapScripts).Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(MapScripts)) && !t.IsAbstract))
            {
                charScripts.Add(T);
            }
            return charScripts;
        }
    }
    public static List<System.Type> GetAllTriggerScripts
    {
        get
        {
            List<System.Type> charScripts = new();
            foreach (System.Type T in typeof(TriggerScript).Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(TriggerScript)) && !t.IsAbstract))
            {
                charScripts.Add(T);
            }
            return charScripts;
        }
    }
    public static string TypeToName(System.Type T) => T.Namespace + '.' + T.Name;
    public static string ObjectNameToPath(string name)
    {
        string[] splitString = name.Split('.');
        (splitString[1], splitString[0]) = (splitString[0], splitString[1]);
        return "Assets/MapScripts/" + string.Join('/', splitString) + "_objectscripts.asset";

    }
    public static string MapscriptNameToPath(string name)
    {
        string[] splitString = name.Split('.');
        (splitString[1], splitString[0]) = (splitString[0], splitString[1]);
        return "Assets/MapScripts/" + string.Join('/', splitString) + "_mapscripts.asset";

    }
    public static string TriggerNameToPath(string name)
    {
        string[] splitString = name.Split('.');
        (splitString[1], splitString[0]) = (splitString[0], splitString[1]);
        return "Assets/MapScripts/" + string.Join('/', splitString) + "_triggerscript.asset";

    }

    public static string PathToDirectory(string path)
    {
        string[] splitString = path.Split('/');
        return string.Join('/', splitString.SkipLast(1));
    }

    public static string TypeToObjectPath(this System.Type T) => ObjectNameToPath(TypeToName(T));
    public static string TypeToTriggerPath(this System.Type T) => TriggerNameToPath(TypeToName(T));
    public static string TypeToMapscriptPath(this System.Type T) => MapscriptNameToPath(TypeToName(T));
    [MenuItem("Services/NameTest")]
    public static void NameTest()
    {
        foreach (System.Type T in GetAllCharScripts)
        {
            Debug.Log(ObjectNameToPath(TypeToName(T)));
        }
    }
    [MenuItem("Services/Create Missing Scripts")]
    public static void CreateMissingScripts()
    {
        foreach (System.Type T in GetAllCharScripts)
        {
            string newPath = T.TypeToObjectPath();
            if (!AssetDatabase.LoadAssetAtPath<CharScripts>(newPath))
            {
                var newObject = ScriptableObject.CreateInstance(T);
                if (!Directory.Exists(PathToDirectory(newPath)))
                    _ = Directory.CreateDirectory(PathToDirectory(newPath));
                AssetDatabase.CreateAsset(newObject, newPath);
            }
        }
        foreach (System.Type T in GetAllMapScripts)
        {
            string newPath = T.TypeToMapscriptPath();
            if (!AssetDatabase.LoadAssetAtPath<MapScripts>(newPath))
            {
                var newObject = ScriptableObject.CreateInstance(T);
                if (!Directory.Exists(PathToDirectory(newPath)))
                    _ = Directory.CreateDirectory(PathToDirectory(newPath));
                AssetDatabase.CreateAsset(newObject, newPath);
            }
        }
        foreach (System.Type T in GetAllTriggerScripts)
        {
            string newPath = T.TypeToTriggerPath();
            if (!AssetDatabase.LoadAssetAtPath<TriggerScript>(newPath))
            {
                var newObject = ScriptableObject.CreateInstance(T);
                if (!Directory.Exists(PathToDirectory(newPath)))
                    _ = Directory.CreateDirectory(PathToDirectory(newPath));
                AssetDatabase.CreateAsset(newObject, newPath);
            }
        }
    }
}

#endif