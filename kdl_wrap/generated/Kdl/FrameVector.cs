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

public class FrameVector : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<Frame>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FrameVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FrameVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(FrameVector obj) {
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

  ~FrameVector() {
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
          kdlPINVOKE.delete_FrameVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public FrameVector(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Frame element in c) {
      this.Add(element);
    }
  }

  public FrameVector(global::System.Collections.Generic.IEnumerable<Frame> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Frame element in c) {
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

  public Frame this[int index]  {
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

  public void CopyTo(Frame[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(Frame[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, Frame[] array, int arrayIndex, int count)
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

  public Frame[] ToArray() {
    Frame[] array = new Frame[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<Frame> global::System.Collections.Generic.IEnumerable<Frame>.GetEnumerator() {
    return new FrameVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new FrameVectorEnumerator(this);
  }

  public FrameVectorEnumerator GetEnumerator() {
    return new FrameVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class FrameVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<Frame>
  {
    private FrameVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public FrameVectorEnumerator(FrameVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Frame Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (Frame)currentObject;
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
    kdlPINVOKE.FrameVector_Clear(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(Frame x) {
    kdlPINVOKE.FrameVector_Add(swigCPtr, Frame.getCPtr(x));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = kdlPINVOKE.FrameVector_size(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = kdlPINVOKE.FrameVector_capacity(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    kdlPINVOKE.FrameVector_reserve(swigCPtr, n);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameVector() : this(kdlPINVOKE.new_FrameVector__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameVector(FrameVector other) : this(kdlPINVOKE.new_FrameVector__SWIG_1(FrameVector.getCPtr(other)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameVector(int capacity) : this(kdlPINVOKE.new_FrameVector__SWIG_2(capacity), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  private Frame getitemcopy(int index) {
    Frame ret = new Frame(kdlPINVOKE.FrameVector_getitemcopy(swigCPtr, index), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Frame getitem(int index) {
    Frame ret = new Frame(kdlPINVOKE.FrameVector_getitem(swigCPtr, index), false);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Frame val) {
    kdlPINVOKE.FrameVector_setitem(swigCPtr, index, Frame.getCPtr(val));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(FrameVector values) {
    kdlPINVOKE.FrameVector_AddRange(swigCPtr, FrameVector.getCPtr(values));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = kdlPINVOKE.FrameVector_GetRange(swigCPtr, index, count);
    FrameVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new FrameVector(cPtr, true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Frame x) {
    kdlPINVOKE.FrameVector_Insert(swigCPtr, index, Frame.getCPtr(x));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, FrameVector values) {
    kdlPINVOKE.FrameVector_InsertRange(swigCPtr, index, FrameVector.getCPtr(values));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    kdlPINVOKE.FrameVector_RemoveAt(swigCPtr, index);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    kdlPINVOKE.FrameVector_RemoveRange(swigCPtr, index, count);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static FrameVector Repeat(Frame value, int count) {
    global::System.IntPtr cPtr = kdlPINVOKE.FrameVector_Repeat(Frame.getCPtr(value), count);
    FrameVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new FrameVector(cPtr, true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    kdlPINVOKE.FrameVector_Reverse__SWIG_0(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    kdlPINVOKE.FrameVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, FrameVector values) {
    kdlPINVOKE.FrameVector_SetRange(swigCPtr, index, FrameVector.getCPtr(values));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
