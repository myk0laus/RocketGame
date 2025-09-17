using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    public static BackgroundMusic instance;

    public void Init()
    { 
        if (instance == null)
        {
            instance = this; 
            DontDestroyOnLoad(gameObject);
            _audioSource.Play();
        }
        else if (instance != this)
        {       
            Destroy(gameObject);
        }
    }
}