using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwapScenes : MonoBehaviour
{
    [SerializeField] private BoxCollider player;
    public static bool IsTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            IsTriggered = true;
        }
    }

   
}
