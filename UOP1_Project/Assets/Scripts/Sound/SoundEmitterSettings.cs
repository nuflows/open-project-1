﻿using System;
using UnityEngine;
using UnityEngine.Audio;

public class SoundEmitterSettings
{
	public AudioMixerGroup OutputAudioMixerGroup = null;
	public bool Mute = false;
	public bool BypassEffects = false;
	public bool BypassListenerEffects = false;
	public bool BypassReverbZones = false;
	public bool Loop = false;
	public int Priority = 128;
	public float Volume = 1f;
	public float Pitch = 1f;
	public float PanStereo = 0f;
	public float SpatialBlend = 0f;
	public float ReverbZoneMix = 1f;
	public float DopplerLevel = 1f;
	public float Spread = 0f;
	public AudioRolloffMode RolloffMode = AudioRolloffMode.Logarithmic;
	public float MinDistance = 1f;
	public float MaxDistance = 500f;
	public bool IgnoreListenerVolume = false;
	public bool IgnoreListenerPause = false;
}
