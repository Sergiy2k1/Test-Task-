using CodeBase.Global;
using CodeBase.Scenes;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public enum LevelType
    {
        CharacterSelector,
        Game
    }
    public class LoadSceneButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private LevelType levelType;

        private void Start()
        {
            button.onClick.AddListener(Load);
        }

        private void OnDisable()
        {
            button.onClick.RemoveAllListeners();
        }
        private void Load()
        {
            string sceneName = GetSceneName(levelType);
            SceneLoader.LoadScene(sceneName);
        }

        private string GetSceneName(LevelType type)
        {
            switch (type)
            {
                case LevelType.CharacterSelector:
                    return SceneNames.CHARACTER_SELECTOR;
                case LevelType.Game:
                    return SceneNames.GAME_SCENE;
                default:
                    return SceneNames.GAME_SCENE;
            }
        }
    }
}
