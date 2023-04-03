using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource _music;
    [SerializeField] private GameObject _offMusic;

    public static  bool isMusic;

    private void Start()
    {
        isMusic = true;
        _music.Play();
    }

    public void OnClick()
    {
        isMusic = !isMusic;
        
        if(isMusic)
        {
            _music.volume = 1;
            _offMusic.SetActive(false);
        }
        else
        {
            _music.volume = 0;
            _offMusic.SetActive(true);
        }
    }
}
