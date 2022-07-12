/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardianEnforcer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enforcer.TrackingChanged += UpdateCenter;
    }

    void UpdateCenter()
    {
        if(OVRManager.boundary.GetConfigured())
        {

            boundary = OVRManager.boundary.GetDimensions(OVRBoundary.BoundaryType.PlayArea);
            points = OVRManager.boundary.GetGeometry(OVRBoundary.BoundaryType.PlayArea);
            CenterPlayer();
        }
    }
    
    void CenterPlayer()
    {
        point1.transform.localPosition = (points[0]);
        point2.transform.localPosition = (points[1]);
        point3.transform.localPosition = (points[2]);
        point4.transform.localPosition = (points[3]);

        Vector3 pointA = midPoint(point1.transform.position, point2.transform.position);
        Vector3 pointB = midPoint(point3.transform.position, point4.transform.position);

        Vector3 between = pointB - pointA;

        float distance = between.magnitude;

        squareMarker.transform.position = pointA + (between / 2.0f);
        squareMarker.transform.LookAt(pointB);

        worldContainer.transform.position = squareMarker.transform.position;
        worldContainer.transform.rotation = squareMarker.transform.rotation;
    }

    Vector3 midPoint(Vector3 a, Vector3 b)
    {
    float x = (a.x + b.x) / 2;
    float y = (a.y + b.y) / 2;
    float z = (a.z + b.z) / 2;

    return new Vector3(x, y, z);
    }
}
 */