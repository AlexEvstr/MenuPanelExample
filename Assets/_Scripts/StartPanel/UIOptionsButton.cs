using UnityEngine;

public class UIOptionsButton : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _optionsPanel;
    [SerializeField] private AudioSource _clickSound;

    public void OnClick()
    {
        if (UISoundButton.isSound == true)
        {
            _clickSound.Play();
        }
        _startPanel.SetActive(false);
        _optionsPanel.SetActive(true);
    }
}
