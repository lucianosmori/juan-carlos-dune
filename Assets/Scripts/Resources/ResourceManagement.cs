using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManagement : MonoBehaviour
{
    private Dictionary<string, Object> resources;

    void Awake()
    {
        resources = new Dictionary<string, Object>();
    }

    public T LoadResource<T>(string resourcePath) where T : Object
    {
        if (resources.ContainsKey(resourcePath))
        {
            return resources[resourcePath] as T;
        }

        T resource = Resources.Load<T>(resourcePath);
        if (resource != null)
        {
            resources[resourcePath] = resource;
        }
        return resource;
    }

    public void UnloadResource(string resourcePath)
    {
        if (resources.ContainsKey(resourcePath))
        {
            Resources.UnloadAsset(resources[resourcePath]);
            resources.Remove(resourcePath);
        }
    }

    public Object GetResource(string resourcePath)
    {
        resources.TryGetValue(resourcePath, out Object resource);
        return resource;
    }
}