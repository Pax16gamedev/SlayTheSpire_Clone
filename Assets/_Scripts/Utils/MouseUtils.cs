using UnityEngine;

public static class MouseUtils
{
    private static Camera camera = Camera.main;

    //public static Vector3 GetMousePositionInWorldSpace()
    //{
    //    Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    p.z = 0;
    //    return p;
    //}

    public static Vector3 GetMousePositionInWorldSpace(float zValue = 0f)
    {
        Plane dragPlane = new(camera.transform.forward, new Vector3(0, 0, zValue));
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if(dragPlane.Raycast(ray, out float distance))
        {
            return ray.GetPoint(distance);
        }
        return Vector3.zero;
    }
}
