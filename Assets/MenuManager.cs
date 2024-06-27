using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject menuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuOn(){
        Time.timeScale = 0;
        menuUI.SetActive(true);
        }
    
    public void MenuOff(){
        menuUI.SetActive(false);
        Time.timeScale = 1;
    }

}
