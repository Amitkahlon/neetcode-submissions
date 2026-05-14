class Solution:
    def isValid(self, s: str) -> bool:
        stack = []

        for c in s:
            if c == '[' or c == '{' or c == '(':
                stack.append(c)
            else:
                if not stack:
                    return False   
                curr = stack.pop()
                if curr == '[' and not c == ']':
                    return False
                if curr == '(' and not c == ')':
                    return False
                if curr == '{' and not c == '}':
                    return False                
        
        return len(stack) == 0 