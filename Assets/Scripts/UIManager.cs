using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        if (startButton == null)
            startButton = GameObject.FindGameObjectWithTag("StartButton").GetComponent<Button>();

        if (startButton)
            startButton.onClick.AddListener(StartHunt);

    }

    public void StartHunt()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
