using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private TMP_Text pointText;
    [SerializeField] private TMP_Text pointShadowText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pointText.text = "Point : " + GameManager.point.ToString();
        pointShadowText.text = "Point : " + GameManager.point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
