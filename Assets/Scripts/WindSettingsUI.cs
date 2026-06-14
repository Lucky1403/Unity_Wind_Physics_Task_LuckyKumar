using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WindSettingsUI : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject settingsButton;
    public DynamicWindController windController;

    public Slider speedSlider;
    public Slider strengthSlider;
    public Slider dirXSlider;
    public Slider dirZSlider;

    public TextMeshProUGUI speedText;
    public TextMeshProUGUI strengthText;
    public TextMeshProUGUI dirXText;
    public TextMeshProUGUI dirZText;

    void Awake()
    {
        settingsPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Start()
    {
        speedSlider.onValueChanged.AddListener((val) => {
            windController.SetWindSpeed(val);
            speedText.text = val.ToString("F1");
        });

        strengthSlider.onValueChanged.AddListener((val) => {
            windController.SetWindStrength(val);
            strengthText.text = val.ToString("F1");
        });

        dirXSlider.onValueChanged.AddListener((val) => {
            windController.SetWindDirectionX(val);
            dirXText.text = val.ToString("F1");
        });

        dirZSlider.onValueChanged.AddListener((val) => {
            windController.SetWindDirectionZ(val);
            dirZText.text = val.ToString("F1");
        });

        speedText.text = speedSlider.value.ToString("F1");
        strengthText.text = strengthSlider.value.ToString("F1");
        dirXText.text = dirXSlider.value.ToString("F1");
        dirZText.text = dirZSlider.value.ToString("F1");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePanel();
        }
    }

    public void TogglePanel()
    {
        bool isActive = settingsPanel.activeSelf;
        settingsPanel.SetActive(!isActive);
        settingsButton.SetActive(isActive);

        if (!isActive)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void ResetWindSettings()
    {
        speedSlider.value = 1f;
        strengthSlider.value = 1f;
        dirXSlider.value = 1f;
        dirZSlider.value = 0f;

        speedText.text = "1.0";
        strengthText.text = "1.0";
        dirXText.text = "1.0";
        dirZText.text = "0.0";
    }
}