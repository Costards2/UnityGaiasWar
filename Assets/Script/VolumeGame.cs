using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeGame : MonoBehaviour
{
    [SerializeField] private AudioSource volumeGameBack;
    [SerializeField] private AudioSource volumeEndGameTerra;
    [SerializeField] private AudioSource volumeEndGameMarte;
    [SerializeField] private AudioSource bulletEarth;
    [SerializeField] private AudioSource bulletMars;

    public void VolumedoGame(float value)
    {
        volumeGameBack.volume = value;
        volumeEndGameTerra.volume = value;
        volumeEndGameMarte.volume = value;
        bulletEarth.volume = value;
        bulletMars.volume = value;
    }

}
