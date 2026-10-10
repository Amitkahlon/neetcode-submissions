class Solution {
    public boolean isAnagram(String s, String t) {
        int[] a1 = new int[26];
        int[] a2 = new int[26];
        
        for(int i = 0; i < s.length(); i++) {
            int cIndex = s.charAt(i) - 'a';
            a1[cIndex] += 1;
        }

        for(int i = 0; i < t.length(); i++) {
            int cIndex = t.charAt(i) - 'a';
            a2[cIndex] += 1;
        }

        String s1 = "";
        String s2 = "";

        for(int i = 0; i < a1.length; i++) {
            s1 += Integer.toString(a1[i]);
        }

        for(int i = 0; i < a2.length; i++) {
            s2 += Integer.toString(a2[i]);
        }
        
        System.out.println(s1);
        System.out.println(s2);
        return s1.equals(s2);
    }
}
