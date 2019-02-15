using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSequenceButton : MonoBehaviour {
    public void LoadScene(int level)
    {
        SceneManager.LoadScene("MainMenu");
    }


}
