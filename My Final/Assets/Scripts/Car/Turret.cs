using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] private AudioSource _AudioSource;
    [SerializeField] private string targetTag = "Zombie";
    [SerializeField] private float turnSpeed;
    [SerializeField] public float fireRate = 1f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletSpeed = 10f;
    public bool EnableShooting { get; private set; } = false;
    public bool CanShoot = true;

    private float nextFireTime;
    public void SetEnableShooting(bool value)
    {
        EnableShooting = value;
    }

    private void Update()
    {
        RotateTowardsClosestTarget();
        ShootClosestTarget();
    }

    private void RotateTowardsClosestTarget()
    {
        Transform closestTarget = FindClosestTargetWithTag(targetTag);

        if (closestTarget != null)
        {
            var trans = transform;
            var position = trans.position;
            var targetPos = closestTarget.position;

            var targetDirection = targetPos - position;
            var newDirection = Vector3.RotateTowards(trans.forward, targetDirection, turnSpeed * Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }

    private void ShootClosestTarget()
    {
        if (EnableShooting && CanShoot && Time.time >= nextFireTime)
        {
            _AudioSource.Play();
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    private Transform FindClosestTargetWithTag(string tag)
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(tag);
        Transform closestTarget = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject target in targets)
        {
            float distance = Vector3.Distance(transform.position, target.transform.position);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestTarget = target.transform;
            }
        }

        return closestTarget;
    }
}
