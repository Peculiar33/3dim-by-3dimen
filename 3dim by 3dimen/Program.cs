namespace _3dim_by_3dimen
{
    internal class Program
    {
        static void Main(string[] args)
        {  // MultiDim.
            int[,,] FristArray = new int[3, 2, 3]

            {

            {{3,4,8}, {5,7,5}},
            {{4,3,2}, {9,5,3}},
            {{3,7,4}, {2,4,3}}
            };
            int[,,] SecondArray = new int[3, 2, 3]
            {
             {{ 3,4,8}, { 5,7,5}},
            {{ 4,3,2}, { 9,5,3}},
            {{ 3,7,4}, { 2,4,3}}

            };
            int[,,] thirdArray = new int[3, 2, 3];
            for (int i = 0; i < FristArray.GetLength(0); i++)

            {
                for (int j = 0; j < SecondArray.GetLength(1); j++)
                 {
                    for (int k = 0; k < SecondArray.GetLength(2); k++)
                    {
                        thirdArray[i, j, k] += FristArray[i, j, k] * SecondArray[i, j, k];

                    }
                 }
               
             }
            foreach(int i in thirdArray)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}