using UnityEngine;

public class Player : MonoBehaviour
{
    public Car Car { get; private set; }

    private void Awake()
    {
        Car = GetComponent<Car>();
    }

    void Update()
    {
        Car.forward = Input.GetAxis("Vertical");
        Car.turn = Input.GetAxis("Horizontal");
    }
}
