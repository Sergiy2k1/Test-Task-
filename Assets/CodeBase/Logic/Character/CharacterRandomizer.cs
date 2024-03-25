using UnityEngine;
using System.Collections.Generic;

namespace CodeBase.Logic.Character
{
    public class CharacterRandomizer<T>
    {
        private List<T> characterDataList;

        public CharacterRandomizer(List<T> dataList)
        {
            characterDataList = dataList;
        }

        public T GetRandomObject()
        {
            if (characterDataList.Count > 0)
            {
                int randomIndex = Random.Range(0, characterDataList.Count);
                return characterDataList[randomIndex];
            }
            else
            {
                return default;
            }
        }
    }
}


