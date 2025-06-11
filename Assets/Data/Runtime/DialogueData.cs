using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class DialogueData
{
  [SerializeField]
  int id;
  public int ID { get {return id; } set { this.id = value;} }
  
  [SerializeField]
  int characteridx;
  public int Characteridx { get {return characteridx; } set { this.characteridx = value;} }
  
  [SerializeField]
  int characteremotion;
  public int Characteremotion { get {return characteremotion; } set { this.characteremotion = value;} }
  
  [SerializeField]
  int position;
  public int Position { get {return position; } set { this.position = value;} }
  
  [SerializeField]
  string bg;
  public string BG { get {return bg; } set { this.bg = value;} }
  
  [SerializeField]
  string dialogue;
  public string Dialogue { get {return dialogue; } set { this.dialogue = value;} }
  
}