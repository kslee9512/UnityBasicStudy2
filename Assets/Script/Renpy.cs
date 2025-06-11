using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG;
    [SerializeField] Image[] img_Character;
    [SerializeField] TextMeshProUGUI tmp_Name;
    [SerializeField] TextMeshProUGUI tmp_NameInfo;
    [SerializeField] TextMeshProUGUI tmp_Dialogue;
    int idxCount = 0;

    private void Start()
    {
        //UpdateData();
    }
    public void OnClickNext()
    {
        UpdateData();
    }

    private void UpdateData()
    {
        var dialogueData = SData.GetDialogueData(idxCount);
        if (dialogueData != null)
        {
            UpdateBG(dialogueData.BG);
            UpdatePosition(dialogueData.Position);
        }
        else
        {
            Debug.LogError($"Dialogue ÀÎµ¦½º¸¦ ¹þ¾î³µ½À´Ï´Ù! IDXNUM : {idxCount}");
            return;
        }
        if(dialogueData != null)
        {
            var characterData = SData.GetCharacterData(dialogueData.Characteridx);
            UpdateCharacterImage(characterData.Imagedirection, dialogueData.Characteremotion);
            UpdateCharacterInfo(characterData.Name, characterData.Title);
            UpdateDialogue(dialogueData.Dialogue);
        }
    }

    private void UpdateBG(string BGName)
    {
        if (BGName == string.Empty || BGName == null)
        {
            return;
        }
        else
        {
            string path = "Img/Background/" + BGName;
            img_BG.sprite = Resources.Load<Sprite>(path);
        }
    }

    private void UpdatePosition(int _PosNum)
    {
        switch (_PosNum)
        {
            case 5:
                img_Character[0].GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                break;
        }
    }

    private void UpdateCharacterImage(string PathName, int EmotionNum)
    {
        string path = PathName + EmotionNum.ToString();
        img_Character[0].sprite = Resources.Load<Sprite>(path);
    }

    private void UpdateCharacterInfo(string Charactername, string CharacterNameInfo)
    {
        tmp_Name.text = Charactername;
        tmp_NameInfo.text = CharacterNameInfo;
    }

    private void UpdateDialogue(string characterDialogue)
    {
        tmp_Dialogue.text = characterDialogue;
    }
}
