using UnityEngine;

public class rooster : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Die", 40);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Die()
    {
        Destroy(this.gameObject);
        hud.incrementRoosterCount(-1);
    }
}
