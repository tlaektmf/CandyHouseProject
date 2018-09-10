using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeDirector : MonoBehaviour {
    public void SceneChangeToSecondScene()
    {
        SceneManager.LoadScene("SecondScene");
    }
    public void SceneChangeToSettingScene()
    {
        SceneManager.LoadScene("settingScene");
    }
}
