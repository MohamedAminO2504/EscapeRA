using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Map))]
public class MapEditor : Editor {
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
                Map map = (Map) target;

         if (GUILayout.Button("Create Piece")) //10
        {
            map.CreateRoom();
        }  
        try
        {
                  foreach (var item in map.getRooms())
        {
            if (GUILayout.Button("Supprime Piece "+item.name)) //10
            {

                map.RemoveRoom(item);
            }  
        }
        }
        catch (System.Exception)
        {
                    }
  
    }
}