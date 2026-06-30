using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pointText;
    public static int point = 0;
    [SerializeField] GameObject timerText;
    [SerializeField] float time = 40.0f;

    public void HitEnemy()
    {
        point += 100;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        pointText.GetComponent<TextMeshProUGUI>().text = point + " point";
        if(time <= 0) { SceneManager.LoadScene("ResultScene"); }
    }
}
