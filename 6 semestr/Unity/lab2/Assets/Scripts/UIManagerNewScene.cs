using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerNewScene : MonoBehaviour
{
    public InputField platformsNumber;
    public InputField piesNumber;

    // Start is called before the first frame update
    void Start()
    {
        platformsNumber.placeholder.GetComponent<Text>().text = PrefsClass.platformsNumb.ToString();
        piesNumber.placeholder.GetComponent<Text>().text = PrefsClass.piesNumb.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToNextScene(int index)
    {
        if (platformsNumber.text == "")
            PrefsClass.platformsNumb = int.Parse(platformsNumber.placeholder.GetComponent<Text>().text);
        else
            PrefsClass.platformsNumb = int.Parse(platformsNumber.text);
        if (piesNumber.text == "")
            PrefsClass.piesNumb = int.Parse(piesNumber.placeholder.GetComponent<Text>().text);
        else
            PrefsClass.piesNumb = int.Parse(piesNumber.text);
        SceneManager.LoadScene(index);
    }
}
