using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public float countdown = 60.0f;
    //public float NowTime;
    public Text timeText;
    public Slider Timer;
    float maxTime = 60f;
    float lTime;
    [SerializeField]
    private GameManager GM;
    [SerializeField]
    private GameObject Ball;

    [SerializeField]
    private BallScrypt BScrypt;
    //public float StartTime;

    // Start is called before the first frame update
    void Start()
    {
        Timer.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //NowTime = Time.deltaTime - BScrypt.StartTime; 
        //countdown -= NowTime;
        countdown -= Time.deltaTime;
        countdown = Mathf.Min(countdown, maxTime);
        lTime = countdown / maxTime;
        Timer.value = Mathf.Lerp(0f, 1f , lTime);
        timeText.text = countdown.ToString("f2");
        if (countdown <= 0)
        {
            // 0秒になったときの処理
        Destroy(Ball);
        GM.GameOver();
        }
    }
}
