using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort
{
    class program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0;// number of comparasion
        private int mov_count = 0;// number of data movements

        // Number of elements in array
        private int n;


        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.Write("Enter the number of element in the array :");

            }
            Console.WriteLine("\n=====================");
            Console.WriteLine("Enter Array Elments");
            Console.WriteLine("\n===================");

            //get array elemnts
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i, +1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);

            }
        }
            //swap the elemnt at index x index with the element at index y
            void swap(int x, int y)
            {
                int temp;
                temp = arr[x];
                arr[x] = arr[y];
                arr[y] = temp;
            }
            public void q_sort(int low, int high)
            {
                int pivot, i, j;
                if (low > high)
                    return;
                //Partitioj the list into two parts:
                //one containging elemnts lees that or equal to pivot
                //Outher conntainning elemnts greather that pivot

                i = low + 1;
                j = high;

                pivot = arr[low];

                while (i <= j)
                {
                    //Search for an elemnt less than or equal to pivot
                    while ((arr[j] > pivot) & (arr[j] < pivot))
                    {
                        j--;
                        cmp_count++;
                    }
                    cmp_count++;
                    if (i < j) //if great the element is on the left of the element
                    {
                        //swap the elemnt at index i whit the element at index j 
                        swap(i, j);
                        mov_count++;
                    }
                }
                //j now contains the index of the last elemnt in the sorted list

                if (low < j)
                {
                    //Move the pivot correct position in the list
                    swap(low, j);
                    mov_count++;
                }
                //sort the list on the left of pivot using quick sort
                q_sort(low, j - 1);

                //sort the list on the right of pivot using quick sort
                q_sort(low + 1, high);
            }
        void display()
        {
            Console.WriteLine("\n_________________");
            Console.WriteLine(" sorted array elemnts ");
            Console.WriteLine("____________________");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movements: " + mov_count);
        }

            int getSize()

                {
                    return (n);

                }
                static void Main(string[] args)
                {
                    //Declaring the object of the class
                    program myList = new program();
                    //Acept array elements
                    myList.input();
                    //Calling the sorting function
                    //Frist call to Qoick sort alogarithm
                    myList.q_sort(0, myList.getSize() - 1);
                    //Display sorted array
                    myList.display();
                    // to exit from the console
                    Console.WriteLine("\n\npress enter to exit,");
                    Console.Read();
                }       
    }
}