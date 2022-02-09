namespace GenericArrayCreator
{
    public class ArrayCreator
    {

        /// <summary>
        /// The method should return an array with the given length and every element should be set to the given default item.
        /// </summary>
        /// <param name="lenght"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static T[] Create<T>(int lenght, T item)
        {
            T[] array = new T[lenght];
            for (int i = 0; i < lenght; i++)
            {
                array[i] = item;
            }

            return array;
        }
    }
}
