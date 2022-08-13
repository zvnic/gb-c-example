// See https://aka.ms/new-console-template for more information


string text = "rt rtrt rt rte et345345 3--- 345345 3453 34";


string Replace(string text, char oldVlue, char newValue) {
    
    string result = String.Empty;

    for(int i=0; i < text.Length; i++) {
        if(text[i] == oldVlue) {
            result = result + $"{newValue}";
        } else {
            result = result +$"{text[i]}";
        }
    }
    return result;
}

Console.WriteLine(Replace(text, '-', '&'));
