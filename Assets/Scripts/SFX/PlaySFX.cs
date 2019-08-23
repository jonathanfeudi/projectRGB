using UnityEngine;

public class PlaySFX : MonoBehaviour
{
    public AudioClip SFX;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(SFX, transform.position);
    }
}



