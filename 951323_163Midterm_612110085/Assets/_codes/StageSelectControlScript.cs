using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectControlScript : MonoBehaviour
{
    [SerializeField] Button _stageButton1;
    [SerializeField] Button _stageButton2;
    [SerializeField] Button _backButton;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
        _stageButton1.onClick.AddListener(delegate { StageOneButtonClick(_stageButton1); });
        _stageButton2.onClick.AddListener(delegate { StageTwoButtonClick(_stageButton2); });
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StageOneButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneGameplay");
        SingletonGameManager.Instance.GameScore++;
    }

    public void StageTwoButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneGameplay2");
        SingletonGameManager.Instance.GameScore++;
    }

    public void BackToMainMenuButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneMainMenu");
        SingletonGameManager.Instance.GameScore++;
    }
}
