using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Room", menuName = "Escape Game/Room", order = 0)]
public class RoomBuilder : ScriptableObject
{
    public GameObject sol;
    public GameObject mur;


    public List<GameObject> fournitures;
    public List<GameObject> wallDeco;

    public float distance = 1.25f;
    public int raportMurSol = 2;
}
