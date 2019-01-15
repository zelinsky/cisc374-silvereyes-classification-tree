using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button button1, button2, button3;
    private Bird[] birds;

    private void Awake()
    {
        birds = (Bird[]) FindObjectsOfType<Bird>();
    }

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        button1.onClick.AddListener(OnClickColor);
        button2.onClick.AddListener(OnClickHeight);
        button3.onClick.AddListener(OnClickFlight);
    }

    void OnClickHeight()
    {
        //Output this to console when Button1 or Button3 is clicked
        foreach(Bird b in birds)
        {
            if(b.height > 1)
            {
                b.gameObject.layer = 8;
            }
            else
            {
                b.gameObject.layer = 9;
            }
        }
    }
    void OnClickColor()
    {
        //Output this to console when Button1 or Button3 is clicked
        foreach (Bird b in birds)
        {
            if (b.color.Equals("brown"))
            {
                b.gameObject.layer = 8;
            }
            else
            {
                b.gameObject.layer = 9;
            }
        }
    }
    void OnClickFlight()
    {
        //Output this to console when Button1 or Button3 is clicked
        foreach (Bird b in birds)
        {
            if (b.flight)
            {
                b.gameObject.layer = 8;
            }
            else
            {
                b.gameObject.layer = 9;
            }
        }
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
