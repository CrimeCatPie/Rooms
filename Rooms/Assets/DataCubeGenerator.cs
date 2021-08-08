using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCubeGenerator : MonoBehaviour
{
    public GameObject DataCubePrefab;
    public float updatePeriodSec = 1.0f;

    void Start()
    {
        InvokeRepeating("CreateDataCube", 0.0f, updatePeriodSec);
    }

    void CreateDataCube()
    {
        if (DataCubePrefab != null) {
            float x = Random.Range(-12.0f, 15.0f);
            float y = Random.Range(37.0f, 60.0f);
            float z = 148.0f;
            Instantiate(DataCubePrefab, new Vector3(x, y, z), Quaternion.identity);
        }
    }
}
