//using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public int[] ranking = new int[3];
    public Text FstScore;
    public Text SndScore;
    public Text TrdScore;

    // Start is called before the first frame update
    void Start()
    {
        ranking[0] = PlayerPrefs.GetInt("FirstScore");
        ranking[1] = PlayerPrefs.GetInt("SecondScore");
        ranking[2] = PlayerPrefs.GetInt("ThirdScore");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveScore(int score){
    for (var i=0; i<ranking.Length; i++) {
        if (ranking[i] < score) {

    switch(i){
        case 0:
        //if(ranking[0] < score){
            ranking[2] = ranking[1];
            ranking[1] = ranking[0];
            ranking[0] = score;
            goto End;
        //}
        case 1:
        //if(ranking[1] < score){
            ranking[2] = ranking[1];
            ranking[1] = score;
            goto End;
        //}
        case 2:
        //if(ranking[2] < score){
            ranking[2] = score;
            goto End;
        //}

    }
    End:
    break;
    }

    }
    
    FstScore.text = "1st:   " + ranking[0].ToString();
    SndScore.text = "2nd:   " + ranking[1].ToString();
    TrdScore.text = "3rd:   " + ranking[2].ToString();

    PlayerPrefs.SetInt("FirstScore" ,ranking[0]);
    PlayerPrefs.SetInt("SecondScore" ,ranking[1]);
    PlayerPrefs.SetInt("ThirdScore" ,ranking[2]);

    }
}
