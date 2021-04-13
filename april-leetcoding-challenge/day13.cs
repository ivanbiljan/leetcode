/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    private readonly Queue<int> _queue = new Queue<int>();

    public NestedIterator(IList<NestedInteger> nestedList) {
        BuildQueue(nestedList, _queue);
        
        void BuildQueue(IList<NestedInteger> list, Queue<int> queue) {
            if (list == null) {
                return;
            }
            
            foreach (var item in list) {
                if (item.IsInteger())
                {
                    queue.Enqueue(item.GetInteger());
                    continue;
                }
                
                BuildQueue(item.GetList(), queue);
            }
        }
    }

    public bool HasNext() {
        return _queue.Count > 0;
    }

    public int Next() {
        return _queue.Dequeue();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */