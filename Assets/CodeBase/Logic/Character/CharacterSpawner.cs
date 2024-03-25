using CodeBase.Data.Character;
using CodeBase.Logic.Character;
using UnityEngine;

namespace CodeBase.Logic.Charactar
{
    public class CharacterSpawner
    {
        CharacterLoader _characterLoader;
        GameObject _previousCharacter;

        public void SpawnCharacter()
        {
            _characterLoader = new CharacterLoader();
            _characterLoader.LoadCharactersConfig();
            _characterLoader.GetCurrentCharter();

            CharacterConfig currentCharter = _characterLoader.GetCurrentCharter();

            if (currentCharter != null)
            {
                if (_previousCharacter != null)
                {
                    GameObject.Destroy(_previousCharacter);
                }

                _previousCharacter = GameObject.Instantiate(currentCharter.CharterPrefab, currentCharter.CharterPrefab.transform.position, Quaternion.identity);
            }
        }

        public void SpawnRandomCharacter()
        {
            _characterLoader = new CharacterLoader();
            _characterLoader.LoadCharactersConfig();
            CharacterConfig randomCharacterData = _characterLoader.GetRandomCharacter();

            if (randomCharacterData != null)
            {
                if (_previousCharacter != null)
                {
                    GameObject.Destroy(_previousCharacter);
                }

                _previousCharacter = GameObject.Instantiate(randomCharacterData.CharterPrefab, randomCharacterData.CharterPrefab.transform.position, Quaternion.identity);
            }
        }
    }

}

