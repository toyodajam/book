using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
public GameObject GameStartUI;
public GameObject TargetStartUI;

    // Start is called before the first frame update
    void Start()
    {
        GameStartUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void TargetStart()
    {
        SceneManager.LoadScene("Target2");
    }

}
