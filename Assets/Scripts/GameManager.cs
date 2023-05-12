using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_InputField userInputField;
    public Text bestScoreText;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        DataManager.Instance.LoadData();
        bestScoreText.text = "Best Score: " + DataManager.Instance.BestScoreUserName + " : " + DataManager.Instance.BestScore;
    }

    public void StartButtonPress()
    {
        DataManager.Instance.name = userInputField.text;
        SceneManager.LoadScene(1);
    }

    public void QuitButtonPress()
    {
        Application.Quit();
    }
}