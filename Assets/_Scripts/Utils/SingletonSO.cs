using UnityEngine;

// Debe de haberse creado un asset de tipo T para que funcione
// y que este en Resources/Managers
public class SingletonSO<T> : ScriptableObject where T : ScriptableObject
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load<T>($"Managers/{typeof(T).Name}");

                if (_instance == null)
                {
                    Debug.LogError($"No se encontró una instancia de {typeof(T).Name} en Resources/Managers. " +
                        $"Asegúrate de tenerla en una carpeta llamada 'Resources/Managers'.");
                }
            }
            return _instance;
        }
    }
}
