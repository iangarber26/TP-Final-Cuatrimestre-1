using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColision : MonoBehaviour
{
    public GameObject Confeti;
    GameObject clon;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstacle")
        {
            SceneManager.LoadScene("GAME_OVER");
        }

        if (collision.gameObject.name == "Ground123")
        {
            for(int i = 0; i<=20; i++)
            {
                Confeti.SetActive(true);
                clon = Instantiate(Confeti);
                Destroy(clon, 6);
            }
        }

        if (collision.gameObject.tag == "Confeti")
        {
            SceneManager.LoadScene("GAME_OVER");
            Debug.Log("Confeti");
        }
        if (collision.gameObject.name == "DeathFloor")
        {
            SceneManager.LoadScene("GAME_OVER");
        }
        if (collision.gameObject.name == "Finish")
        {
            SceneManager.LoadScene("You_win");
        }
    }

}