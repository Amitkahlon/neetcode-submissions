class Solution {
    
    public String arrayToString(int[] arr) {
        String s = "";

        for(int i = 0; i < arr.length; i++) {
            s += Integer.toString(arr[i]);
            s += " ";
        }

        return s;
    }
    
    public List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String, List<String>> m = new HashMap<>();
        
        for (String s : strs) {
            int[] arr = new int[26];

            for(int i = 0; i < s.length(); i++ ){
                int charIndex = s.charAt(i) - 'a';
                arr[charIndex] += 1;
            }

            String repStr = arrayToString(arr); 

    
            if(!m.containsKey(repStr)) {
                m.put(repStr, new ArrayList<String>());
            }

            m.get(repStr).add(s);
        }

        return new ArrayList<List<String>>(m.values());


    }
}
