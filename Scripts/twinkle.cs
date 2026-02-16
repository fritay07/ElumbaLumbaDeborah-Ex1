using UnityEngine;

public class twinkle : MonoBehaviour
{
    public float tauxReduction = 0.01f;
    private bool petit = true;

    void Update()
    {
        Vector3 taille = transform.localScale;

        if (petit)
            taille.x -= tauxReduction;
        else
            taille.x += tauxReduction;

            taille.y = taille.x;

        if (taille.x < 0.3f) petit = false;
        if (taille.x > 1.0) petit = true;

        transform.localScale = new Vector3(taille.x, taille.y, taille.z);
    }
}

