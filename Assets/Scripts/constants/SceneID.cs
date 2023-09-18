using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneID
{
    Main,
    Map,
    Battle,
}

public static class SceneUtils
{
    public static AsyncOperation Load(this SceneID id) => SceneManager.LoadSceneAsync((int)id);
}