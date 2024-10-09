using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Counter()
    {
        SceneManager.LoadScene("Counter");
    }

    public void Blending()
    {
        SceneManager.LoadScene("Blending");
    }

    public void Toppings()
    {
        SceneManager.LoadScene("Toppings");
    }

    public void HomeScreen()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
