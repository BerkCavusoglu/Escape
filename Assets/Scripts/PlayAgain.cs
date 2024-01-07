using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public int skor;
    public void YenidenOyna()
    {
        Time.timeScale = 1; // Oyun hızını aktif et
        hak.kalanHak = 3; // Kalan hak sayısını 3 olarak ayarlayın
        skor = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Geçerli sahneyi yeniden yükleyin
    }
}
