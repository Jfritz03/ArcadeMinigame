using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int P1Lives = 3;
    public int P2Lives = 3;
    public GameObject Player1Prefab;
    public GameObject Player2Prefab;
    public TextMeshProUGUI P1Wins;
    public TextMeshProUGUI P2Wins;
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
        // Final Life Lost
        if (Player1Prefab.transform.position.y < -5 && P1Lives == 1)
        {
            Destroy(Player1Prefab);
            // destroy winner
            Destroy(Player2Prefab);
            P1Lives--;
            //Display player 2 win screen
            P2Wins.gameObject.SetActive(true);
        }
        // player 2 section
        if (Player2Prefab.transform.position.y < -5 && P2Lives > 1)
        {
            Player2Prefab.transform.position = new Vector3(144, 11, 87);
            P2Lives--;
        }
        //final life lost
        if (Player2Prefab.transform.position.y < -5 && P2Lives == 1)
        {
            Destroy(Player2Prefab);
            // destroy winning player
            Destroy(Player1Prefab);
            P2Lives--;
            //Display player 1 win screen
            P1Wins.gameObject.SetActive(true);
        }
        

    }
}
