using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerWin : MonoBehaviour
{
    public Text Congratulations;
    public GameObject Girl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string Output = "Поздравляем!\nВы собрали " + PrefsClass.PickedPies + " пирожков из " + PrefsClass.piesNumb + ".\nОтличный результат!";
        Congratulations.text = Output;
    }
    public void GoToNextScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
