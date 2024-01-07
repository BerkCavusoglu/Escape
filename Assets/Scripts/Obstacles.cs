using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Obstacles : MonoBehaviour
{
    public int skor;
    public TextMeshProUGUI skorYazisi, bitisYazisi;

    void Start()
    {
        
    }

    void Update()
    {
        UpdateScoreText();
        FinishScoreText();
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        float xPozisyonu = Random.Range(-5f, 5f);
        float yPozisyonu = Random.Range(6.5f, 15f);

        if (temas.gameObject.tag == "Kontrol_Cubugu")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            skor = 0;
            skor += Random.Range(8, 14);
            UpdateScoreText();
        }
        else if (temas.gameObject.tag == "Karakter")
        {
            transform.position = new Vector2(xPozisyonu, yPozisyonu);
            hak.kalanHak--;
        }
    }

    void UpdateScoreText()
    {
        skorYazisi.text = skor.ToString();
    }

    void FinishScoreText()
    {
        if (hak.kalanHak == 0)
        {
            bitisYazisi.text = "Oyun Bitti! \n Skor : " + skor.ToString(); // Skoru ekrana yazdır
            skorYazisi.text = ""; // Skor yazısını temizle
        }
    }

    
}
