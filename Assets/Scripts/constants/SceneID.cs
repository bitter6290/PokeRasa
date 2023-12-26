using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneID //Make sure this matches the list in Build Settings!
{
    Main,
    Map,
    Battle,
    Evolution,
    Bag,
    Party,
}

public static class SceneUtils
{
    public static AsyncOperation Load(this SceneID id) => SceneManager.LoadSceneAsync((int)id);
}