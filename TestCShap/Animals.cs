using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace TestCSharp
{
    public class Animals : DictionaryBase
    {
        public Animal this[int animalIndex]
        {
            get { return (Animal) Dictionary[animalIndex]; }
            set { Dictionary[animalIndex] = value; }
        }

        public void Add(string newID, Animal newAnimal)
        {
            Dictionary.Add(newID, newAnimal);
        }

        public void Remove(string oldID)
        {
            Dictionary.Remove(oldID);
        }

        public Animal this[string animalID]
        {
            get { return (Animal) Dictionary[animalID]; }
            set { Dictionary[animalID] = value; }
        }

        /// <summary>
        /// 使用迭代器
        /// </summary>
        /// <returns></returns>
        public new IEnumerator GetEnumerator()
        {
            foreach (var animal in Dictionary.Values)
            {
                yield return (Animal) animal;
            }
        }
    }
}