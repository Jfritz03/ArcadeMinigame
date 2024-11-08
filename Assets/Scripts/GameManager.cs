using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float P1Lives = 3;
    public float P2Lives = 3;
    public GameObject Player1Prefab;
    public GameObject Player2Prefab;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
        // resets player position when falling off map while removing a life
        if (Player1Prefab.transform.position.y < -5 && P1Lives > 1)
        {
            Player1Prefab.transform.position = new Vector3(-31, 11, -79);
            P1Lives--;
        }
        if (Player1Prefab.transform.position.y < -5 && P1Lives == 1)
        {
            Destroy(Player1Prefab);
            P1Lives--;
            //Display player 2 win screen
        }
        // player 2 section
        if (Player2Prefab.transform.position.y < -5 && P2Lives > 1)
        {
            Player2Prefab.transform.position = new Vector3(144, 11, 87);
            P2Lives--;
        }
        if (Player2Prefab.transform.position.y < -5 && P2Lives == 1)
        {
            Destroy(Player2Prefab);
            P2Lives--;
            //Display player 1 win screen
        }
    }
}
