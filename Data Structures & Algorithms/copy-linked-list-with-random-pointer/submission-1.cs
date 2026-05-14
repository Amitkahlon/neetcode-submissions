/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
        public Node copyRandomList(Node head)
        {
                        if (head == null) return null;

            Dictionary<Node, Node> nodes = new Dictionary<Node, Node>();

            var curr = head;

            while (curr != null)
            {
                var copy = new Node(curr.val);
                nodes.Add(curr, copy);
                curr = curr.next;
            }

            curr = head;

            while (curr != null)
            {
                var copy = nodes[curr];
                if (curr.next is not null) copy.next = nodes[curr.next];
                if (curr.random is not null) copy.random = nodes[curr.random];
             curr = curr.next;
            }

            return nodes[head];


        }
}
