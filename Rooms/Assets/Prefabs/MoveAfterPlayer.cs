using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAfterPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private GameObject surface;
    [SerializeField] private Renderer ground;
    //[SerializeField] private float speed;
    //private const string MAINTEX = "_MainTex";


    private Vector3 offset;

    //private float offset = 20f;
    void Start()
    {
        
        offset = transform.position - new Vector3 (playerCamera.position.x, surface.transform.position.y, playerCamera.position.z); 
    }

    // Update is called once per frame
    void Update()
    {
        float x = playerCamera.position.x;
        float z = playerCamera.position.z;
        Vector3 pos = new Vector3(x, surface.transform.position.y, z);
        surface.transform.position = pos + offset;
        //ground.material.SetTextureOffset(MAINTEX, new Vector2(playerCamera.position.x, playerCamera.position.y));
    }
}
