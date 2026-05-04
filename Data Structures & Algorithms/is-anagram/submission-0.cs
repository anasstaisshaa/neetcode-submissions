public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        char[] ArrS = s.ToCharArray();
        char[] ArrT = t.ToCharArray();
        Array.Sort(ArrS);
        Array.Sort(ArrT);

        return ArrS.SequenceEqual(ArrT);
    }
}
