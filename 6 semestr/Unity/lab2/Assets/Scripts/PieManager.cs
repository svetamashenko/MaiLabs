using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieManager : MonoBehaviour
{
    public GameObject PieGen;
    private int NumbOfPies = PrefsClass.piesNumb;
    private int NumbOfPlatforms = PrefsClass.platformsNumb;

    // Start is called before the first frame update
    void Start()
    {
        CreatePies();
    }
    private void CreatePies()
    {
        float x = -1;
        float y = -1;
        for (int i = 0; i < NumbOfPies - 1; i++)
        {
            x = Random.Range(-2.4f, 2.5f);
            y = Random.Range(-0.9f, NumbOfPlatforms - 1.3f);
            GameObject newPie = Instantiate(PieGen, new Vector3(x, y, gameObject.transform.position.z), Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
