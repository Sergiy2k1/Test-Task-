using CodeBase.Data.Character;
using CodeBase.Global;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CodeBase.Logic.Character
{
    public class CharacterLoader
    {
        private const string CharacterPath = "Character/Prefabs";
        private const string DefaultLevel = "0";

        private static List<CharacterConfig> characterList;

        public CharacterLoader()
        {
            LoadCharactersConfig();
        }

        public void LoadCharactersConfig()
        {
            var allCharacterData = Resources.LoadAll<CharacterConfig>(CharacterPath);
            characterList = new List<CharacterConfig>();
            foreach (var characterGameObject in allCharacterData)
            {
                characterList.Add(characterGameObject);
            }
        }

        public CharacterConfig GetCurrentCharter()
        {
            if (characterList == null || characterList.Count == 0)
            {
                 return null;
            }

            string currentPlayerID = PlayerPrefs.GetString(PrefsKeys.CURRENT_PLAYER_ID, DefaultLevel);
            CharacterConfig currentCharter = characterList.FirstOrDefault(character => character.ID == currentPlayerID);

            return currentCharter;
        }

        public CharacterConfig GetRandomCharacter()
        {
            if (characterList == null || characterList.Count == 0)
            {
                return null;
            }
            CharacterRandomizer<CharacterConfig> randomizer = new CharacterRandomizer<CharacterConfig>(characterList);
            CharacterConfig randomCharacter = randomizer.GetRandomObject();

            SetCurrentPlayerID(randomCharacter.ID);

            return randomCharacter;
        }

        private void SetCurrentPlayerID(string playerID) => PlayerPrefs.SetString(PrefsKeys.CURRENT_PLAYER_ID, playerID);
    }
}
