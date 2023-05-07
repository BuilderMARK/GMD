using UnityEngine;
using UnityEngine.AI;

public class CarController : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;

    private int currentWaypointIndex = 0;
    private NavMeshAgent navMeshAgent;
    private Rigidbody rb;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
        navMeshAgent.updatePosition = false;
    }

    private void Update()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance + 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
        }

        MoveCar();
    }

    private void MoveCar()
    {
        Vector3 targetDirection = navMeshAgent.steeringTarget - transform.position;
        targetDirection.y = 0f; // Ignore vertical difference

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        float distanceToTarget = Vector3.Distance(transform.position, navMeshAgent.steeringTarget);
        //Debug.Log("Distance to target: " + distanceToTarget);
        //Debug.Log("NavMeshAgent stopping distance: " + navMeshAgent.stoppingDistance);

        if (distanceToTarget > navMeshAgent.stoppingDistance + 0.1f)
        {
            rb.velocity = transform.forward * moveSpeed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}