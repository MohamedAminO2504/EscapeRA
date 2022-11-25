using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Info", menuName = "Escape Game/Info", order = 0)]
public class InfoData : ScriptableObject
{
    public string titre;
[TextArea(4, 100)] [SerializeField]
    public string description;
    public string info1;
    public string info2;
    public Sprite image;
    public Sprite image2;
}
