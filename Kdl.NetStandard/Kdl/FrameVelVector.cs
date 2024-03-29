//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Kdl {

public class FrameVelVector : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<FrameVel>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FrameVelVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FrameVelVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(FrameVelVector obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~FrameVelVector() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          kdlPINVOKE.delete_FrameVelVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public FrameVelVector(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (FrameVel element in c) {
      this.Add(element);
    }
  }

  public FrameVelVector(global::System.Collections.Generic.IEnumerable<FrameVel> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (FrameVel element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public FrameVel this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < 0 || (uint)value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(FrameVel[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(FrameVel[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, FrameVel[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public FrameVel[] ToArray() {
    FrameVel[] array = new FrameVel[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<FrameVel> global::System.Collections.Generic.IEnumerable<FrameVel>.GetEnumerator() {
    return new FrameVelVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new FrameVelVectorEnumerator(this);
  }

  public FrameVelVectorEnumerator GetEnumerator() {
    return new FrameVelVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class FrameVelVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<FrameVel>
  {
    private FrameVelVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public FrameVelVectorEnumerator(FrameVelVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public FrameVel Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (FrameVel)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    kdlPINVOKE.FrameVelVector_Clear(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(FrameVel x) {
    kdlPINVOKE.FrameVelVector_Add(swigCPtr, FrameVel.getCPtr(x));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = kdlPINVOKE.FrameVelVector_size(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = kdlPINVOKE.FrameVelVector_capacity(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    kdlPINVOKE.FrameVelVector_reserve(swigCPtr, n);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameVelVector() : this(kdlPINVOKE.new_FrameVelVector__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameVelVector(FrameVelVector other) : this(kdlPINVOKE.new_FrameVelVector__SWIG_1(FrameVelVector.getCPtr(other)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameVelVector(int capacity) : this(kdlPINVOKE.new_FrameVelVector__SWIG_2(capacity), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  private FrameVel getitemcopy(int index) {
    FrameVel ret = new FrameVel(kdlPINVOKE.FrameVelVector_getitemcopy(swigCPtr, index), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private FrameVel getitem(int index) {
    FrameVel ret = new FrameVel(kdlPINVOKE.FrameVelVector_getitem(swigCPtr, index), false);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, FrameVel val) {
    kdlPINVOKE.FrameVelVector_setitem(swigCPtr, index, FrameVel.getCPtr(val));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(FrameVelVector values) {
    kdlPINVOKE.FrameVelVector_AddRange(swigCPtr, FrameVelVector.getCPtr(values));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameVelVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = kdlPINVOKE.FrameVelVector_GetRange(swigCPtr, index, count);
    FrameVelVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new FrameVelVector(cPtr, true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, FrameVel x) {
    kdlPINVOKE.FrameVelVector_Insert(swigCPtr, index, FrameVel.getCPtr(x));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, FrameVelVector values) {
    kdlPINVOKE.FrameVelVector_InsertRange(swigCPtr, index, FrameVelVector.getCPtr(values));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    kdlPINVOKE.FrameVelVector_RemoveAt(swigCPtr, index);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    kdlPINVOKE.FrameVelVector_RemoveRange(swigCPtr, index, count);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static FrameVelVector Repeat(FrameVel value, int count) {
    global::System.IntPtr cPtr = kdlPINVOKE.FrameVelVector_Repeat(FrameVel.getCPtr(value), count);
    FrameVelVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new FrameVelVector(cPtr, true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    kdlPINVOKE.FrameVelVector_Reverse__SWIG_0(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    kdlPINVOKE.FrameVelVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, FrameVelVector values) {
    kdlPINVOKE.FrameVelVector_SetRange(swigCPtr, index, FrameVelVector.getCPtr(values));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
