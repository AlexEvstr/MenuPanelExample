using UnityEngine;


public class UISoundButton : MonoBehaviour
{
    [SerializeField] private GameObject _offSound;
    public static bool isSound;

    private void Start()
    {
        isSound = true;
    }

    public void OnClick()
    {
        isSound = !isSound;
    }

    private void Update()
    {
        if(isSound == false)
        {
            _offSound.SetActive(true);
        }
        else
        {
            _offSound.SetActive(false);
        }

    }
}

