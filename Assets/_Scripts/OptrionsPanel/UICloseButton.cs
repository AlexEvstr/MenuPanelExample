using UnityEngine;

public class UICloseButton : MonoBehaviour
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
        _optionsPanel.SetActive(false);
        _startPanel.SetActive(true);
    }
}
