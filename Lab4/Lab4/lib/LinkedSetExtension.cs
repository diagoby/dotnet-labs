namespace Lab4.lib
{
    static class LinkedSetExtension
    {
        public static void CopyTo<T>(this LinkedSet<T> set, T[] arr, int index = 0){
            int i = index < 0 ? -1 : index - 1;

            foreach (var item in set)
            {
                if (++i > arr.Length - 1) return;

                arr[i] = item;
            }
        }
    }
}
