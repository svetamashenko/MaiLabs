using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    private int NumbOfPlatforms = PrefsClass.platformsNumb - 1;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, NumbOfPlatforms + 0.17f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
