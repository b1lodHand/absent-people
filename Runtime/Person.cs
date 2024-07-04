using UnityEngine;

namespace com.absence.personsystem
{
    [CreateAssetMenu(menuName = "absencee_/absent-people/Person", fileName = "New Person")]
    public class Person : ScriptableObject
    {
        [SerializeField] private string m_name;
        [SerializeField] private string m_description;
        [SerializeField] private Sprite m_icon;

        public string Name => m_name;
        public string Description => m_description;
        public Sprite Icon => m_icon;
    }

}