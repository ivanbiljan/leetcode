public class MyCircularQueue {
    // TODO: array implementation
    private readonly LinkedList _list = new LinkedList();
    private int _capacity;
    private int _count;
    
    public MyCircularQueue(int k) {
        _capacity = k;
    }
    
    public bool EnQueue(int value) {
        if (_count == _capacity) {
            return false;
        }
        
        _list.Add(value);
        ++_count;
        return true;
    }
    
    public bool DeQueue() {
        if (_count > 0) {
            _list.Remove(0);
            --_count;
            return true;
        }
        
        return false;
    }
    
    public int Front() {
        return _list.Get(0)?.Value ?? -1;
    }
    
    public int Rear() {
        return _list.Get(_count - 1)?.Value ?? -1;
    }
    
    public bool IsEmpty() {
        return _count == 0;
    }
    
    public bool IsFull() {
        return _count == _capacity;
    }
}
            
public sealed class Node {
    public Node(int value, Node next = null) {
        Value = value;
        Next = next;
    }
    
    public int Value {get;set;}
    public Node Next {get;set;}
}

public sealed class LinkedList {
    private Node _head;
    
    public void Add(int value) {
        if (_head == null) {
            _head = new Node(value);
            return;
        }
        
        Node walker = _head;
        while (walker.Next != null) {
            walker = walker.Next;
        }
        
        walker.Next = new Node(value);
    }
    
    public void Remove(int index) {
        if (index == 0 && _head != null) {
            _head = _head.Next;
            return;
        }
        
        var walker = _head;
        for (; index - 1 > 0; walker = walker.Next, --index);
        if (walker.Next != null)
            walker.Next = walker.Next.Next;
    }
    
    public Node Get(int index) {
        var walker = _head;
        for (; index > 0; --index) {
            if (walker != null) {
                walker = walker.Next;
            }
        }
        
        return walker;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */