using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{   
    private GameObject sol;
    private GameObject mur;

    public int x;
    public int y;
    private float distance;
    private int raportMurSol;

    public RoomBuilder roomBuilder;

    public List<GameObject> roomsCreated; 

    public List<GameObject> walls;

    public void CreateRoom(){
                walls = new List<GameObject>();

        GameObject room = new GameObject(roomBuilder.name);
        sol = roomBuilder.sol;
        mur = roomBuilder.mur;
        distance = roomBuilder.distance;
        raportMurSol = roomBuilder.raportMurSol;
        CreateFloor(room.transform);
        CreateMur(room.transform);
        AfficheFurnitures(room.transform);
        roomsCreated.Add(room);
    }

    public List<GameObject> getRooms(){
        return roomsCreated;
    }

    public void RemoveRoom(GameObject r){
        roomsCreated.Remove(r);
  
        DestroyImmediate(r);
    }

    public void AfficheFurnitures(Transform room){
         GameObject floor = new GameObject("furniture");
                        floor.transform.parent = room;
        foreach (var item in roomBuilder.fournitures)
        {
            Vector3 pos = new Vector3(Random.Range(0, x), 0.09f, Random.Range(0, y));
                GameObject o = Instantiate(item, pos,  Quaternion.identity);
                o.transform.Rotate(0f,0f,0f);
                o.transform.parent = floor.transform;
        }
    }

    public void CreateFloor(Transform room){
        GameObject floor = new GameObject("floor");
                        floor.transform.parent = room;

        for (var i = 0; i < x; i++)
        {
             for (var j = 0; j < y; j++)
            {
                Vector3 pos = new Vector3(distance*i, 0, distance*j);
                GameObject o = Instantiate(sol, pos,  Quaternion.identity);
                o.transform.Rotate(180f,0f,0f);
                o.transform.parent = floor.transform;
            }
        }
    }

    public void CreateWallDeco(Transform room){
        foreach (var item in roomBuilder.wallDeco)
        {
            try
            {
                  GameObject a = walls[(int) Random.Range(0, walls.Count)];
                if(a == null){
                    a = walls[(int) Random.Range(0, walls.Count)];
                }
                GameObject o = Instantiate(item, a.transform.position, a.transform.rotation);
                o.transform.parent = room;
                DestroyImmediate(a);  
            }
            catch (System.Exception)
            {
                            }
        
        }
    }

    public void CreateMur(Transform room){
        GameObject wall = new GameObject("wall");
        wall.transform.parent = room;
        for(int i = 0; i< y/raportMurSol; i++){
            Vector3 pos = new Vector3(distance*(x-1) , 0, -distance + distance*raportMurSol*i );
             GameObject o = Instantiate(mur, pos, Quaternion.identity );
             o.transform.Rotate(0f,90f,0f);
                             o.transform.parent = wall.transform;
            walls.Add(o);

        }

        for(int i = 0; i< y/raportMurSol; i++){
            Vector3 pos = new Vector3(-distance, 0,  +i*raportMurSol + (1f/2f)*i + distance);
             GameObject o = Instantiate(mur, pos, Quaternion.identity );
             o.transform.Rotate(0f,-90f,0f);
                            o.transform.parent = wall.transform;
            walls.Add(o);

        }


       for(int i = 0; i< x/raportMurSol; i++){
            Vector3 pos = new Vector3(i*raportMurSol + (1f/2f)*i + distance,  0   ,distance*(y-1));
             GameObject o = Instantiate(mur, pos, Quaternion.identity );
             o.transform.Rotate(0f,0f,0f);
                        o.transform.parent = wall.transform;
            walls.Add(o);

        }

        for(int i = 0; i< x/raportMurSol; i++){
            Vector3 pos = new Vector3(i*raportMurSol - distance + (1f/2f)*i ,  0   ,-distance);
             GameObject o = Instantiate(mur, pos, Quaternion.identity );
             o.transform.Rotate(0f,180f,0f);
                        o.transform.parent = wall.transform;
            walls.Add(o);

        }

                CreateWallDeco(wall.transform);

       /* for(int i = 0; i< x/raportMurSol; i++){
            Vector3 pos = new Vector3(0,0,0);
            Instantiate(mur, pos, Quaternion.identity ).transform.Rotate(0f,90f,0f);
        }*/
      
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
