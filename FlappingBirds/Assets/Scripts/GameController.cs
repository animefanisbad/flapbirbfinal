using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject GameOvertext;
    public text ScoreBoard;
    public bool dead = false;
    public float scrollspeed = -1.5f;

    private int score = 0;
   
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (dead)
        {
            return;
        }
        score++;
        ScoreBoard.text = "Score: " + score.ToString();
    }

    public void BirdDie()
    {
        
        GameOvertext.SetActive(true);
        dead = true;
    }
}
