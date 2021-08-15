using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionBehaviour : MonoBehaviour
{
    private static bool isIgnore = false;
    void Update()
    {
        if (isIgnore == true) {
            gameObject.SetActive(false);
        }

        if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
            gameObject.SetActive(false);
            isIgnore = true;
        }
    }
}
