/*
 * CSE212 
 * (c) BYU-Idaho
 * 03-Prove - Problem 1
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code
 * with others or to post it online.  Storage into a personal and private
 * repository (e.g. private GitHub repository, unshared Google Drive
 * folder) is acceptable.
 */
public static class MysteryStack1 {
    public static string Run(string text) {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}

/*
This method takes a string input, reverses the characters and returns the reversed string.

Determine the output of the function if the input text is equal to the following:

Input: racecar
Output: racecar

Input: stressed
Output: desserts 

Input: a nut for a jar of tuna
Output: anut fo raj a rof tun a
*/