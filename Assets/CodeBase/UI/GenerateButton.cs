using CodeBase.Logic.Charactar;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public class GenerateButton : MonoBehaviour
    {
        [SerializeField] private Button button;

        private CharacterSpawner characterSpawner;

        private void Start()
        {
            characterSpawner = new CharacterSpawner();
            button.onClick.AddListener(GenerateCharter);
        }

        private void GenerateCharter()
        {
            characterSpawner.SpawnRandomCharacter();
        }
    }
}
