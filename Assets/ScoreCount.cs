using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text scoreText;
    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
    //scoreText.text = "0";  
    }

    // Update is called once per frame
    void Update()
    {
    scoreText.text = GM.score.ToString();  
    }


}
