using UnityEngine;

public class UIPrevLevels : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel1;
    [SerializeField] private GameObject _levelsPanel2;
    [SerializeField] private AudioSource _clickSound;

    public void Onclick()
    {
        if (UISoundButton.isSound == true)
        {
            _clickSound.Play();
        }
        _levelsPanel1.SetActive(true);
        _levelsPanel2.SetActive(false);
    }
}
