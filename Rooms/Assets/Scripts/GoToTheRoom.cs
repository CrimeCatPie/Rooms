using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToTheRoom : MonoBehaviour
{
    public Rooms Rooms;
    private BoxCollider activeCollider;
    [SerializeField] private GameObject player;
    [SerializeField] private BoxCollider currentCollider, playerCollider;
    [SerializeField] private Transform playerPos;
    

    public static int InitTimes;

    void Awake()
    {
        if (InitTimes < 1) Rooms.Init();
        InitTimes++;

        currentCollider = GetComponent<BoxCollider>();
        playerCollider = player.GetComponent<BoxCollider>();
        activeCollider = currentCollider;

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other == playerCollider)
        {
            Rooms.SpawnRoom(activeCollider, playerPos.position);
            Debug.Log("Spawn");
        }
    }
   

}
