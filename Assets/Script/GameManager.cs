using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pointText;
    [SerializeField] int point = 0;

    public void HitEnemy()
    {
        point += 100;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.GetComponent<TextMeshProUGUI>().text = point + " point";
    }
}
