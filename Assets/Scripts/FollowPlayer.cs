using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject playerTest;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTest.transform.position + new Vector3(0,8,-10);
    }
}





