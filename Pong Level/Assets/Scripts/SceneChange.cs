using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string NextScEnE;
    public void OnClick(string StartButton)
    {
        SceneManager.LoadScene(NextScEnE, LoadSceneMode.Single);
    }
}
