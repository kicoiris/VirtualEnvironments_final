using UnityEngine;

public class GUISome : MonoBehaviour
{
    public void Awake()
    {
        Cursor.visible = false;
    }
  
    public void Update()
    {
        TestScreenCursorLock();
    }

    private void TestScreenCursorLock()
    {
        if (Cursor.lockState != CursorLockMode.Locked && Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}