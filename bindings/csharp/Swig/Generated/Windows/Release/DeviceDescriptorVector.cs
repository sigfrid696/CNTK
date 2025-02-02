//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CNTK {

public class DeviceDescriptorVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<DeviceDescriptor>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DeviceDescriptorVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DeviceDescriptorVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DeviceDescriptorVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_DeviceDescriptorVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public DeviceDescriptorVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (DeviceDescriptor element in c) {
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

  public DeviceDescriptor this[int index]  {
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
      if (value < size())
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

  public void CopyTo(DeviceDescriptor[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(DeviceDescriptor[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, DeviceDescriptor[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<DeviceDescriptor> global::System.Collections.Generic.IEnumerable<DeviceDescriptor>.GetEnumerator() {
    return new DeviceDescriptorVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new DeviceDescriptorVectorEnumerator(this);
  }

  public DeviceDescriptorVectorEnumerator GetEnumerator() {
    return new DeviceDescriptorVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class DeviceDescriptorVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<DeviceDescriptor>
  {
    private DeviceDescriptorVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public DeviceDescriptorVectorEnumerator(DeviceDescriptorVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public DeviceDescriptor Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (DeviceDescriptor)currentObject;
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
    CNTKLibPINVOKE.DeviceDescriptorVector_Clear(swigCPtr);
  }

  public void Add(DeviceDescriptor x) {
    CNTKLibPINVOKE.DeviceDescriptorVector_Add(swigCPtr, DeviceDescriptor.getCPtr(x));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = CNTKLibPINVOKE.DeviceDescriptorVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = CNTKLibPINVOKE.DeviceDescriptorVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    CNTKLibPINVOKE.DeviceDescriptorVector_reserve(swigCPtr, n);
  }

  public DeviceDescriptorVector() : this(CNTKLibPINVOKE.new_DeviceDescriptorVector__SWIG_0(), true) {
  }

  public DeviceDescriptorVector(DeviceDescriptorVector other) : this(CNTKLibPINVOKE.new_DeviceDescriptorVector__SWIG_1(DeviceDescriptorVector.getCPtr(other)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public DeviceDescriptorVector(int capacity) : this(CNTKLibPINVOKE.new_DeviceDescriptorVector__SWIG_2(capacity), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private DeviceDescriptor getitemcopy(int index) {
    DeviceDescriptor ret = new DeviceDescriptor(CNTKLibPINVOKE.DeviceDescriptorVector_getitemcopy(swigCPtr, index), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private DeviceDescriptor getitem(int index) {
    DeviceDescriptor ret = new DeviceDescriptor(CNTKLibPINVOKE.DeviceDescriptorVector_getitem(swigCPtr, index), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, DeviceDescriptor val) {
    CNTKLibPINVOKE.DeviceDescriptorVector_setitem(swigCPtr, index, DeviceDescriptor.getCPtr(val));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(DeviceDescriptorVector values) {
    CNTKLibPINVOKE.DeviceDescriptorVector_AddRange(swigCPtr, DeviceDescriptorVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public DeviceDescriptorVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.DeviceDescriptorVector_GetRange(swigCPtr, index, count);
    DeviceDescriptorVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DeviceDescriptorVector(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, DeviceDescriptor x) {
    CNTKLibPINVOKE.DeviceDescriptorVector_Insert(swigCPtr, index, DeviceDescriptor.getCPtr(x));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, DeviceDescriptorVector values) {
    CNTKLibPINVOKE.DeviceDescriptorVector_InsertRange(swigCPtr, index, DeviceDescriptorVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    CNTKLibPINVOKE.DeviceDescriptorVector_RemoveAt(swigCPtr, index);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    CNTKLibPINVOKE.DeviceDescriptorVector_RemoveRange(swigCPtr, index, count);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static DeviceDescriptorVector Repeat(DeviceDescriptor value, int count) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.DeviceDescriptorVector_Repeat(DeviceDescriptor.getCPtr(value), count);
    DeviceDescriptorVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DeviceDescriptorVector(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    CNTKLibPINVOKE.DeviceDescriptorVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    CNTKLibPINVOKE.DeviceDescriptorVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, DeviceDescriptorVector values) {
    CNTKLibPINVOKE.DeviceDescriptorVector_SetRange(swigCPtr, index, DeviceDescriptorVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(DeviceDescriptor value) {
    bool ret = CNTKLibPINVOKE.DeviceDescriptorVector_Contains(swigCPtr, DeviceDescriptor.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(DeviceDescriptor value) {
    int ret = CNTKLibPINVOKE.DeviceDescriptorVector_IndexOf(swigCPtr, DeviceDescriptor.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(DeviceDescriptor value) {
    int ret = CNTKLibPINVOKE.DeviceDescriptorVector_LastIndexOf(swigCPtr, DeviceDescriptor.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(DeviceDescriptor value) {
    bool ret = CNTKLibPINVOKE.DeviceDescriptorVector_Remove(swigCPtr, DeviceDescriptor.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
