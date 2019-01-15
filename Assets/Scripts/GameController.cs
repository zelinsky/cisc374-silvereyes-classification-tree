using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public int birdPoolSize = 5;
    public GameObject birdPrefab;
    public Button button1, button2, button3, button4;

    private GameObject[] birds;
    private Vector2 objectPoolPosition = new Vector2(0, 5);

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        birds = new GameObject[birdPoolSize];
        for (int i = 0; i < birdPoolSize; i++)
        {
            birds[i] = (GameObject)Instantiate(birdPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        button1.onClick.AddListener(OnClickColor);
        button2.onClick.AddListener(OnClickHeight);
        button3.onClick.AddListener(OnClickFlight);
        button4.onClick.AddListener(OnClickRestart);
    }

    void OnClickHeight()
    {
        //Output this to console when Button1 or Button3 is clicked
        foreach(GameObject b in birds)
        {
            Bird bird; 
            bird = b.GetComponent<Bird>();
            if (bird.height > 1)
                bird.gameObject.layer = 8;
            else
                bird.gameObject.layer = 9;
        }
    }

    void OnClickColor()
    {
        //Output this to console when Button1 or Button3 is clicked
        foreach (GameObject b in birds)
        {
            Bird bird;
            bird = b.GetComponent<Bird>();
            if (bird.color.Equals("brown"))
                bird.gameObject.layer = 8;
            else
                bird.gameObject.layer = 9;
        }
    }
    void OnClickFlight()
    {
        //Output this to console when Button1 or Button3 is clicked
        foreach (GameObject b in birds)
        {
            Bird bird;
            bird = b.GetComponent<Bird>();
            if (bird.flight)
                bird.gameObject.layer = 8;
            else
                bird.gameObject.layer = 9;
        }
    }

    void OnClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

        void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
