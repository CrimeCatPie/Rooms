using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Vector2 groundTextureOffset;
    [SerializeField] CharacterController CharController;
    [SerializeField] private float speed = 10f;
    [SerializeField] private Transform playerCamera;
   
    void Start()
    {
        
    }
    
    void LateUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        
        float z = Input.GetAxis("Vertical");
       
        

        

        Vector3 movement = transform.right * x + playerCamera.forward * z;
       

        CharController.Move(movement * speed * Time.deltaTime);

        
    }
}
