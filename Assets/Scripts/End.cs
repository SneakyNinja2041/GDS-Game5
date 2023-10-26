using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public GameObject fireUI;
    public GameObject electricityUI;
    public GameObject end;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (fireUI.activeSelf && electricityUI.activeSelf)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("Lose");
            }
            if (fireUI.activeSelf)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("Lose");
            }
            if (electricityUI.activeSelf)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("Lose");
            }
            else
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("Win");
            }
        }
    }
}
