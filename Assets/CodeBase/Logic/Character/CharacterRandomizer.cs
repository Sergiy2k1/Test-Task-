using UnityEngine;
using System.Collections.Generic;

namespace CodeBase.Logic.Character
{
    public class CharacterRandomizer<T>
    {
        private List<T> characterDataList;
        private int listCount;

        public CharacterRandomizer(List<T> dataList)
        {
            characterDataList = dataList;
            listCount = characterDataList.Count;
        }

        public T GetRandomObject()
        {
            if (listCount > 0)
            {
                int randomIndex = Random.Range(0, listCount);
                return characterDataList[randomIndex];
            }
            else
            {
                return default;
            }
        }
    }
}


