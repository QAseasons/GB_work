string[] arr_1 = new string[4] {"hello", "2", "world", ":-)"};
string[] arr_2 = new string[arr_1.Length];
void Push_array(string[] arr_1, string[] arr_2){
    int count = 0;
    for (int i = 0; i < arr_1.Length; i++){
    if(arr_1[i].Length <= 3){
        arr_2[count] = arr_1[i];
        count++;
        }
    }
}
void Write_array(string[] array){
    for (int i = 0; i < array.Length; i++)
            Console.Write($"{array[i]} ");
}

Push_array(arr_1, arr_2);
Write_array(arr_2);
