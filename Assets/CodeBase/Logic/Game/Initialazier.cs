using CodeBase.Game;
using UnityEngine;

namespace Assets.CodeBase.Logic.Game
{
    public static class Initialazier
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        static void Initialize()
        {
            GameObject gameController = new GameObject("GameController");
            gameController.AddComponent<GameController>();
        }
    }
}