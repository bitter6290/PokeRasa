using System.Collections.Generic;
using static ScriptDomain;

// When you create a new file with scripts in it, register them by
// creating a dictionary in that file, then adding that dictionary to the
// appropriate dictionary in this file.
public static class AllScripts
{
    public static Dictionary<ScriptDomain, Dictionary<string, ObjectScript>> ObjectScripts = new()
    {
        { Test, Test_Scripts.objectScripts }
    };
    public static Dictionary<string, MapScripts> MapScripts = new()
    {
        { "None", ScriptUtils.NoMapScripts }
    };
}