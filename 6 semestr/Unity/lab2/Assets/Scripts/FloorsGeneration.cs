using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorsGeneration : MonoBehaviour
{
    public GameObject FloorGen;
    private int NumbOfFloors = PrefsClass.platformsNumb;
    // Start is called before the first frame update
    void Start()
    {
        float x = -1;
        for (float i = 0.8f; i < NumbOfFloors - 1; i += 1.0f)
        {
            GameObject newFloor;
            if (x <= 0.5f)
            {
                x = Random.Range(2f, 3f);
                newFloor = Instantiate(FloorGen, new Vector3(x, i, gameObject.transform.position.z), Quaternion.identity);
            }
            else
            {
                x = Random.Range(-1f, 0.5f);
                newFloor = Instantiate(FloorGen, new Vector3(x, i, gameObject.transform.position.z), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
