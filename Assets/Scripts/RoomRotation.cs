using UnityEngine;

public class RoomRotation : MonoBehaviour
{
    public GameObject room;
    public float rotationSpeed;

    bool isRotating = false;
    Quaternion targetRotation = Quaternion.identity;

    enum Floor { Floor, LeftWall, Ceiling, RightWall };

    Floor currentFloor;

    void Start()
    {
        currentFloor = 0;
    }

    void Update()
    {
        room.transform.rotation = Quaternion.RotateTowards(room.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        if (1f - Mathf.Abs(Quaternion.Dot(room.transform.rotation, targetRotation)) < 0.01f)
        {
            isRotating = false;
        }
    }

    // Negative: clockwise, positive: counterclockwise
    public void Rotate(int direction)
    {
        if (isRotating)
        {
            return;
        }

        if (currentFloor == Floor.Floor && direction == -1)
        {
            currentFloor = Floor.RightWall;
        }
        else if (currentFloor == Floor.RightWall && direction == 1) {
            currentFloor = Floor.Floor;
        }
        else
        {
            currentFloor += direction;
        }

        isRotating = true;
        targetRotation = Quaternion.Euler(new Vector3(0f, 0f, (float)currentFloor * 90f));
        Debug.Log(targetRotation);
    }
}
