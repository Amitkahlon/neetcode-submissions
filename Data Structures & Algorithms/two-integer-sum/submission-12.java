class Solution {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> s = new HashMap<>();

        for(int i = 0; i < nums.length; i++){
            int curr = nums[i];
            int diff = target - curr;

            if(s.containsKey(diff)){
                int i1 = i;
                int i2 = s.get(diff);


                return new int[] {Math.min(i1, i2), Math.max(i1, i2)};
            }
            

            s.put(nums[i], i);

        }
        
        return null;

    }
}
