using CodeBase.Global;
using CodeBase.Logic.Charactar;
using CodeBase.Scenes;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;



namespace CodeBase.Game
{
    public class GameController : MonoBehaviour
    {
        public static event Action SceneLoaded;

        private CharacterSpawner characterSpawner;
       

        private void Awake()
        {
            DontDestroyOnLoad(this);
            characterSpawner = new CharacterSpawner();
            SceneLoader.SceneLoaded += OnSceneLoaded;     
        }

        private void OnDisable()
        {
            SceneLoader.SceneLoaded -= OnSceneLoaded;
        }
        private void OnSceneLoaded()
        {
            Scene activeScene = SceneManager.GetActiveScene();
            if (activeScene.name == SceneNames.CHARACTER_SELECTOR) 
            {
                return; 
            }
            characterSpawner.SpawnCharacter();
        }
    }
}
