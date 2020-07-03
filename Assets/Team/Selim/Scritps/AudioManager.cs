using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
	public static AudioManager instance;
	public Sound[] sounds;
	private string currentLoopingPlayMode;
	private List<AudioSource> audioSources = new List<AudioSource>();
	private Transform audioParent;


	void Awake()
	{
		if (instance != null)
		{
			Debug.LogError("More than one AudioManager in scene");
			return;
		}
		instance = this;
	}
	private void Start()
	{
        EventManager.instance.OnWinGame += OnWinGameHandler;
        EventManager.instance.OnMainSong += OnMainSongHandler;
        EventManager.instance.OnCatchBubble += CatchBubbleHandler;
        EventManager.instance.OnDeath += DeathHandler;
        EventManager.instance.InMenu += InMenuHandler;

		GameObject audioParentGO = new GameObject();
		audioParentGO.name = "Sounds";
		audioParent = audioParentGO.transform;
	}

    void OnMainSongHandler(object sender, EventArgs e)
    {
        Sound s = Array.Find(sounds, sound => sound.name == "MainSong");
        if (s != null && s.source != null)
            Destroy(s.source.gameObject);
        AudioManager.instance.Play("MainSong");
    }

    void CatchBubbleHandler(object sender, EventArgs e)
    {
        Sound s = Array.Find(sounds, sound => sound.name == "CatchBubble");
        if (s != null && s.source != null)
            Destroy(s.source.gameObject);
        AudioManager.instance.Play("CatchBubble");
    }


    void OnWinGameHandler (object sender, EventArgs e)
    {
        Sound s = Array.Find(sounds, sound => sound.name == "WinGame");
        	if (s != null && s.source != null)
        		Destroy(s.source.gameObject);
        	AudioManager.instance.Play("WinGame");
    }

    void DeathHandler(object sender, EventArgs e)
    {
        Sound s = Array.Find(sounds, sound => sound.name == "Death");
        if (s != null && s.source != null)
            Destroy(s.source.gameObject);
        AudioManager.instance.Play("Death");
    }

    void InMenuHandler(object sender, EventArgs e)
    {
        Sound s = Array.Find(sounds, sound => sound.name == "Menu");
        if (s != null && s.source != null)
            Destroy(s.source.gameObject);
        AudioManager.instance.Play("Menu");
    }




    //void OnShotInGobeletHandler(object sender, EventManager.ShotInGobeletEventArgs e)
    //{
    //	if(e.gobeletTeam == GameManager.Instance.currentTeamPlaying)
    //	{
    //		Sound s = Array.Find(sounds, sound => sound.name == "OwnCampGoblet");
    //		if (s != null && s.source != null)
    //			Destroy(s.source.gameObject);
    //		AudioManager.instance.Play("OwnCampGoblet");
    //	}
    //	else
    //	{
    //		Sound s = Array.Find(sounds, sound => sound.name == "WinGoblet");
    //		if (s != null && s.source != null)
    //			Destroy(s.source.gameObject);
    //		AudioManager.instance.Play("WinGoblet");
    //	}		
    //}

    public void Play(string name)
	{
		Sound s = Array.Find(sounds, sound => sound.name == name);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}
		GameObject go = new GameObject(s.name);
		go.transform.SetParent(audioParent);
		AudioSource audio = go.AddComponent<AudioSource>();
		s.source = audio;
		audio.volume = s.volume;
		audio.loop = s.loop;

		if (s.randomPitch)
			audio.pitch = UnityEngine.Random.Range(s.pitchRange.x, s.pitchRange.y);
		else
			audio.pitch = 1;

		if (s.clips.Count > 1)
			audio.clip = s.clips[UnityEngine.Random.Range(0, s.clips.Count - 1)];
		else
			audio.clip = s.clips[0];

		if (!audio.loop)
			Destroy(go, audio.clip.length);

		audio.Play();
	}
	public void Stop(string name)
	{
		Sound s = Array.Find(sounds, sound => sound.name == name);
		s.source.Stop();
	}
}
