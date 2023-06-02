public class Solution {
    struct SStruct
    {
        public string orgString;
        public string sortedChars;
    }

    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        var structs = new List<SStruct>();

        foreach(var str in strs) {
            SStruct tempStruct;
            tempStruct.orgString = str;
            tempStruct.sortedChars = new string (str.OrderBy(c => c).ToArray());
            structs.Add(tempStruct);
        }

        var checkList = new List<string>();
        foreach (var myStruct in structs.Where(myStruct => !checkList.Contains(myStruct.sortedChars)))
        {
        checkList.Add(myStruct.sortedChars);
        var strList = structs.
            Where(s => s.sortedChars.Equals(myStruct.sortedChars)).
            Select(s=>s.orgString).ToList();
        result.Add(strList);
        }



        return result;
    }
}