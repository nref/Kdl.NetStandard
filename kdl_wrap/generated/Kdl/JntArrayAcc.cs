//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Kdl {

public class JntArrayAcc : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JntArrayAcc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JntArrayAcc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JntArrayAcc() {
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
          kdlPINVOKE.delete_JntArrayAcc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public JntArray q {
    set {
      kdlPINVOKE.JntArrayAcc_q_set(swigCPtr, JntArray.getCPtr(value));
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = kdlPINVOKE.JntArrayAcc_q_get(swigCPtr);
      JntArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new JntArray(cPtr, false);
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public JntArray qdot {
    set {
      kdlPINVOKE.JntArrayAcc_qdot_set(swigCPtr, JntArray.getCPtr(value));
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = kdlPINVOKE.JntArrayAcc_qdot_get(swigCPtr);
      JntArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new JntArray(cPtr, false);
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public JntArray qdotdot {
    set {
      kdlPINVOKE.JntArrayAcc_qdotdot_set(swigCPtr, JntArray.getCPtr(value));
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = kdlPINVOKE.JntArrayAcc_qdotdot_get(swigCPtr);
      JntArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new JntArray(cPtr, false);
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public JntArrayAcc() : this(kdlPINVOKE.new_JntArrayAcc__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JntArrayAcc(uint size) : this(kdlPINVOKE.new_JntArrayAcc__SWIG_1(size), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JntArrayAcc(JntArray q, JntArray qdot, JntArray qdotdot) : this(kdlPINVOKE.new_JntArrayAcc__SWIG_2(JntArray.getCPtr(q), JntArray.getCPtr(qdot), JntArray.getCPtr(qdotdot)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JntArrayAcc(JntArray q, JntArray qdot) : this(kdlPINVOKE.new_JntArrayAcc__SWIG_3(JntArray.getCPtr(q), JntArray.getCPtr(qdot)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JntArrayAcc(JntArray q) : this(kdlPINVOKE.new_JntArrayAcc__SWIG_4(JntArray.getCPtr(q)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void resize(uint newSize) {
    kdlPINVOKE.JntArrayAcc_resize(swigCPtr, newSize);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public JntArray value() {
    JntArray ret = new JntArray(kdlPINVOKE.JntArrayAcc_value(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public JntArray deriv() {
    JntArray ret = new JntArray(kdlPINVOKE.JntArrayAcc_deriv(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public JntArray dderiv() {
    JntArray ret = new JntArray(kdlPINVOKE.JntArrayAcc_dderiv(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}