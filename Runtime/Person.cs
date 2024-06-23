using UnityEngine;

namespace com.absence.personsystem
{
    [CreateAssetMenu(menuName = "absencee_/absent-people/Person", fileName = "New Person")]
    public class Person : ScriptableObject
    {
        public string Name;
        public string Description;
        public Sprite Icon;
    }

}