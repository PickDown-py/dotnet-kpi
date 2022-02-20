using System.Collections;
using System.Runtime.Serialization;

namespace MMS.LinkedList;

public interface IMLinkedList<T> :
    IReadOnlyCollection<T>,
    ICollection,
    IDeserializationCallback,
    ISerializable,
    IList<T>
{
    event Action<T> ItemAdded;
    event Action<T> ItemRemoved;
    event Action Cleared;

    void AddFirst(T item);
    void AddLast(T item);
    void AddAfter(T after, T item);
    
    T? First { get; }
    T? Last { get; }

    void RemoveFirst();
    void RemoveLast();
    void RemoveAfter(T after);
}