using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    public GameObject Girl;
    public Text Pies;

    // Start is called before the first frame update
    void Start()
    {
        Pies.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Pies.text = Girl.GetComponent<GirlBehaviour>().PieCount.ToString();
    }

    public void GoToNextScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
