using System;
using UnityEngine.SceneManagement;

namespace CodeBase.Scenes
{
    public static class SceneLoader
    {
        public static Action SceneLoaded;
        public static void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            SceneManager.sceneLoaded += (scene, mode) =>
            {
                if (scene.name == sceneName)
                {
                    SceneLoaded.Invoke();
                }
            };
        }


    }
}

