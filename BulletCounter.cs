using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
    public Text counterText;

    void Update()
    {
        int bulletCount = GameObject.FindGameObjectsWithTag("bullet").Length;
        counterText.text = "Bullets: " + bulletCount;
    }
}
