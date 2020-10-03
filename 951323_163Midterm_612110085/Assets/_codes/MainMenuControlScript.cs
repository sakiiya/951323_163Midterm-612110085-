using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControlScript : MonoBehaviour
{
    //Declarationssection
    [SerializeField] Button _StageSelectButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;

    // Start is called before the first frame update
    void Start()
    {
        _StageSelectButton.onClick.AddListener(delegate { StageSelectButtonClick(_StageSelectButton); });
        _optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        _exitButton.onClick.AddListener(delegate { ExitButtonClick(_exitButton); });
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StageSelectButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneStageSelect");
    }

    public void OptionsButtonClick(Button button)
    {
        if (!SingletonGameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
            SingletonGameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }

    public void CreditsButtonClicา(Button button)
    {
        SceneManager.LoadScene("SceneCredits");
    }

    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
}
