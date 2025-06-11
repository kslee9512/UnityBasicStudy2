using System.Security.Cryptography;
using UnityEngine;

public class SData : SingletonBehabiour<SData>
{
    [SerializeField] Character characterDatas;
    [SerializeField] Dialogue dialogueDatas;
    public static CharacterData[] characterData { get { return Instance.characterDatas.dataArray; } }
    public static DialogueData[] dialogueData { get { return Instance.dialogueDatas.dataArray; } }

    public static CharacterData GetCharacterData(int _CharacterIdx)
    {
        for (int i = 0; i < characterData.Length; i++)
            if (characterData[i].ID == _CharacterIdx)
                return characterData[i];
        return null;
    }

    public static DialogueData GetDialogueData(int _IDX)
    {
        for (int i = 0; i < dialogueData.Length; i++)
            if (dialogueData[i].ID == _IDX)
                return dialogueData[i];
        return null;
    }
}
