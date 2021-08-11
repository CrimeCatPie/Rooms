using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDataCube : MonoBehaviour
{
    private static string ColliderName = "DataCube(Clone)";
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if (other.name == ColliderName) {
            Destroy(other.gameObject);
        }
    }
}
