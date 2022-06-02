using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDeVolume : MonoBehaviour
{
    public float volumeMaster, volumeFX, volumeMusica;
    public Slider sliderMaster, sliderFX, sliderMusicas;

    void Start()
    {
        sliderMaster.value = PlayerPrefs.GetFloat("Master");
        sliderFX.value = PlayerPrefs.GetFloat("FX");
        sliderMusicas.value = PlayerPrefs.GetFloat("Musicas");
    }

    void Update()
    {
        
    }
    public void VolumeMaster(float volume)
    {
        volumeMaster = volume;
        AudioListener.volume = volumeMaster;
        PlayerPrefs.SetFloat("Master",volumeMaster);
    }
    public void VolumeFX(float volume)
    {
        volumeFX = volume;
        GameObject[] Fxs = GameObject.FindGameObjectsWithTag("Fx");

        for(int i=0;i<Fxs.Length; i++)
        {
            Fxs[i].GetComponent<AudioSource>().volume = volumeFX;
        }
        PlayerPrefs.SetFloat("FX", volumeFX);

    }
    public void VolumeMusica(float volume)
    {
        volumeMusica = volume;
        GameObject[] Musicas = GameObject.FindGameObjectsWithTag("Musica");

        for (int i = 0; i < Musicas.Length; i++)
        {
            Musicas[i].GetComponent<AudioSource>().volume = volumeMusica;
        }
        PlayerPrefs.SetFloat("Musicas", volumeMusica);
    }
}
