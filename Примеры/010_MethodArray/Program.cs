int[] array = {18,27,36,45,54,63,27,81};
int n = array.Length;
int find = 27;
int index = 0;

while (index < n) {
if (array[index] == find){
   Console.WriteLine (index);
   break;
}
   index = index + 1;
}