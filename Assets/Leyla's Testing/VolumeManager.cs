using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    public Slider musicVolumeSlider;
    public GameObject optionsMenu;

    private void Start()
    {
        optionsMenu.SetActive(false);

        UpdateVolumeSlider();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleOptionsMenu();
        }
    }

    public void ToggleOptionsMenu()
    {
        optionsMenu.SetActive(!optionsMenu.activeSelf);

        if (optionsMenu.activeSelf)
        {
            UpdateVolumeSlider();
        }
    }

    private void UpdateVolumeSlider()
    {
        if (AudioManager.Instance != null && musicVolumeSlider != null)
        {
            musicVolumeSlider.SetValueWithoutNotify(
                AudioManager.Instance.GetMusicVolume()
            );
        }
    }

    public void OnMusicVolumeChanged(float volume)
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.SetMusicVolume(volume);
        }
    }
}
