using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Rooms", menuName = "Rooms")]
public class Rooms : ScriptableObject
{
    [System.Serializable]
    public struct Room
    {
        public BoxCollider Key;
        public GameObject Unit;

    }

    public Room[] Rooms_Obj;
    
    public Dictionary<BoxCollider, Room> RoomsDict;
    public LayerMask m_LayerMask;
    

    public void Init()
    {
        RoomsDict = new Dictionary<BoxCollider, Room>();
        foreach (var obj in Rooms_Obj)
            RoomsDict.Add(obj.Key, obj);
    }

    public void SpawnRoom(BoxCollider key, Vector3 position)
    {


        if (RoomsDict.ContainsKey(key))
        {
            var newRoom = RoomsDict[key].Unit;
            Vector3 newPos = new Vector3(position.x, position.y, position.z);
            Instantiate(newRoom, newPos, Quaternion.identity);
        }

    }

}
