using UnityEngine;

public class UIPlayButton : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _firstLevelsPanel;
    [SerializeField] private AudioSource _clickSound;

    public void OnCkick()
    {
      if(UISoundButton.isSound == true)
        {
            _clickSound.Play();
        }
        _startPanel.SetActive(false);
        _firstLevelsPanel.SetActive(true);
    }
}
