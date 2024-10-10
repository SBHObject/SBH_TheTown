using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharDatabase", menuName = "Character/Database")]
public class CharacterDatabase : ScriptableObject
{
    public List<CharacterData> charDatas = new List<CharacterData>();
}
