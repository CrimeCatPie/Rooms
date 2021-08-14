using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionBehaviour : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
            gameObject.SetActive(false);
        }
    }
}
