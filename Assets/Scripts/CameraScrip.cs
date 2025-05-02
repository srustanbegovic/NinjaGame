using UnityEngine;

public class CameraScrip : MonoBehaviour
{
    public Vector3 offset;
    GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset; 
    }
}
