using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class scrTimelineManager : MonoBehaviour
{
    public PlayableDirector timeline;
    public scrSandwichManager _Manager;
    public AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        timeline.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeline.time > 5.53f)
        {
            _Manager._start = true;
            _audio.Play();
        }
    }
}
