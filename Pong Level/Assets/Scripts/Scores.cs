using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    public int PlayerTopScore = 0;
    public int PlayerBottomScore = 0;

    public string NextScene;
    public string OtherNextScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player Goal Top")
        {
            PlayerTopScore++;
        }
        else if (collision.gameObject.name == "Player Goal Bottom")
        {
            PlayerBottomScore++;
        }

        if (PlayerTopScore == 7)
        {
            SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
        }
        else if (PlayerBottomScore == 7)
        {
            SceneManager.LoadScene(OtherNextScene, LoadSceneMode.Single);
        }
    }
}
