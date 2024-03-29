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

public class TwistAcc : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TwistAcc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TwistAcc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TwistAcc obj) {
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

  ~TwistAcc() {
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
          kdlPINVOKE.delete_TwistAcc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public VectorAcc vel {
    set {
      kdlPINVOKE.TwistAcc_vel_set(swigCPtr, VectorAcc.getCPtr(value));
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = kdlPINVOKE.TwistAcc_vel_get(swigCPtr);
      VectorAcc ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorAcc(cPtr, false);
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VectorAcc rot {
    set {
      kdlPINVOKE.TwistAcc_rot_set(swigCPtr, VectorAcc.getCPtr(value));
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = kdlPINVOKE.TwistAcc_rot_get(swigCPtr);
      VectorAcc ret = (cPtr == global::System.IntPtr.Zero) ? null : new VectorAcc(cPtr, false);
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public TwistAcc() : this(kdlPINVOKE.new_TwistAcc__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public TwistAcc(VectorAcc _vel, VectorAcc _rot) : this(kdlPINVOKE.new_TwistAcc__SWIG_1(VectorAcc.getCPtr(_vel), VectorAcc.getCPtr(_rot)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TwistAcc Zero() {
    TwistAcc ret = new TwistAcc(kdlPINVOKE.TwistAcc_Zero(), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ReverseSign() {
    kdlPINVOKE.TwistAcc_ReverseSign(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public TwistAcc RefPoint(VectorAcc v_base_AB) {
    TwistAcc ret = new TwistAcc(kdlPINVOKE.TwistAcc_RefPoint(swigCPtr, VectorAcc.getCPtr(v_base_AB)), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Twist GetTwist() {
    Twist ret = new Twist(kdlPINVOKE.TwistAcc_GetTwist(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Twist GetTwistDot() {
    Twist ret = new Twist(kdlPINVOKE.TwistAcc_GetTwistDot(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
