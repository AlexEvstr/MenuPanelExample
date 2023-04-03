using UnityEngine;

public class IUHomeButton : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel1;
    [SerializeField] private GameObject _levelsPanel2;
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private AudioSource _clickSound;

    public void OnClick()
    {
        if (UISoundButton.isSound == true)
        {
            _clickSound.Play();
        }
        _levelsPanel1.SetActive(false);
        _levelsPanel2.SetActive(false);
        _startPanel.SetActive(true);
    }
}
