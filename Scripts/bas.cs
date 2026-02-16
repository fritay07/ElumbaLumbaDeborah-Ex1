using UnityEngine;

public class bas : MonoBehaviour
{

    // vitesse de déplacement vers le bas Y
    public float vitesseY = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, -vitesseY, 0.0f);

        if (transform.position.y < -5.0f)
        {

        // vas en haut de l'écran, retourne a son endroit de départ
            transform.position = new Vector2(transform.position.x, 6.0f);
        }
    }
}
