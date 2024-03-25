using UnityEngine;

namespace CodeBase.Data.Character
{
    [CreateAssetMenu(fileName = "CharacterConfig", menuName = "Character/CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private GameObject charterPrefab;

        public string ID { get => id; }
        public GameObject CharterPrefab => charterPrefab;
    }
}

