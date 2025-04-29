using UnityEngine;

public class Car : MonoBehaviour
{
    public Wheel[] frontWhels;
    public Wheel[] backWhels;
    public Wheel[] tractorBackWhels;

    public Rigidbody rb;
    public Transform motobloc;

    public float acceleration;
    public float maxSteeringAngle;
    public float brakeForce;

    [Range(-1, 1)]
    public float forward;

    [Range(-1, 1)]
    public float turn;

    [Range(-1, 1)]
    public float brake;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        BrackeOnMove();
    }

    void Move()
    {
        foreach (var wheel in frontWhels)
        {
            wheel.collider.motorTorque = forward * acceleration;
            //wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle,
            //    turn * maxSteeringAngle, 0.5f);
            wheel.collider.brakeTorque = brake * brakeForce;
        }

        foreach (var wheel in backWhels)
        {
            wheel.collider.brakeTorque = brake * brakeForce;
        }

        motobloc.Rotate(0, 
                turn * maxSteeringAngle, 0);
    }

    void BrackeOnMove()
    {
        foreach (var wheel in frontWhels)
        {
            wheel.collider.brakeTorque = brake * brakeForce;
        }
    }

    public void ShowInventory(CarScriptableObject car)
    {
        //FindObjectOfType<InventoryManager>().ShowSlots(car.spareParts.Count);

        foreach (var part in car.spareParts)
        {
            Debug.Log(part.item);
            FindObjectOfType<InventoryManager>().AddItem(part.item, part.amount);
        }

        //FindObjectOfType<InventoryManager>().DeleteSlot();
    }
}
