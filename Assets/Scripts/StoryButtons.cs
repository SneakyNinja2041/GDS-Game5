using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryButtons : MonoBehaviour
{
    public GameObject context1Button;
    public GameObject context1UI;
    public GameObject context2Button;
    public GameObject context2UI;
    public GameObject context3Button;
    public GameObject context3UI;
    public GameObject context4Button;
    public GameObject context4UI;
    public GameObject context5Button;
    public GameObject context5UI;

    public GameObject background1;
    public GameObject background2;

    public GameObject lizard1;
    public GameObject lizard2;

    public void Next1()
    {
        context1Button.SetActive(false);
        context1UI.SetActive(false);
        context2Button.SetActive(true);
        context2UI.SetActive(true);
    }

    public void Next2()
    {
        context2Button.SetActive(false);
        context2UI.SetActive(false);
        context3Button.SetActive(true);
        context3UI.SetActive(true);

        background1.SetActive(false);
        background2.SetActive(true);

        lizard1.SetActive(false);
        lizard2.SetActive(true);
    }

    public void Next3()
    {
        context3Button.SetActive(false);
        context3UI.SetActive(false);
        context4Button.SetActive(true);
        context4UI.SetActive(true);
    }

    public void Next4()
    {
        context4Button.SetActive(false);
        context4UI.SetActive(false);
        context5Button.SetActive(true);
        context5UI.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
