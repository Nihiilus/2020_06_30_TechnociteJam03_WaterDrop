using UnityEngine.Audio;
using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Sound
{
	public string name;

	public List<AudioClip> clips;

	[Range(0f, 1f)]
	public float volume;

	public bool randomPitch;
	public Vector2 pitchRange = new Vector2(0.9f, 1.1f);

	public bool loop;

	[HideInInspector] public AudioSource source;
	public List<AudioSource> sources;
}

