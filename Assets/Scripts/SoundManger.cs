using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Sound
{
    BGM,
    EnemyDie,
}

public class SoundManager
{
    AudioSource[] _audioSources = new AudioSource[2];
    Dictionary<string, AudioClip> _audioClips = new Dictionary<string, AudioClip>();

/*    public void Init()
    {
        GameObject root = GameObject.Find("SoundManager");
        if (root == null)
        {
            root = new GameObject { name = "SoundManager" };
            Object.DontDestroyOnLoad(root);

            string[] soundNames = System.Enum.GetNames(typeof(Sound)); // "BGM", "EnemyDie"
            for (int i = 0; i < soundNames.Length - 1; i++)
            {
                GameObject go = new GameObject { name = soundNames[i] };
                _audioSources[i] = go.AddComponent<AudioSource>();
                go.transform.parent = root.transform;
            }

            // _audioSources[(int)Sound.BGM].loop = true; // BGM ������ ���� �ݺ� ���
        }
    }

    public void Clear()
    {
        // ����� ���� ��� ��ž, ���� ����
        foreach (AudioSource audioSource in _audioSources)
        {
            audioSource.clip = null;
            audioSource.Stop();
        }
        // ȿ���� Dictionary ����
        _audioClips.Clear();
    }
*/


}
