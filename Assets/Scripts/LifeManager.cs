using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{

    public int startingLifes;
    private int lifeCounter;
    private Text theText;

    void Start()
    {
        theText = GetComponent<Text>();

        lifeCounter = startingLifes;     
    }


    void Update()
    {
        if(lifeCounter == 0)
        {
          //  gameOver();
        }

        theText.text = "Lifes x" + lifeCounter;
    }

    public void takeLife()
    {
        lifeCounter--;
    }
/*
    public void gameOver()
    {
        Application.LoadLevel( 0 );
    }
*/
}
