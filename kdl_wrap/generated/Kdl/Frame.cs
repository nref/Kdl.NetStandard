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

public class Frame : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Frame(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Frame obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Frame obj) {
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

  ~Frame() {
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
          kdlPINVOKE.delete_Frame(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Vector p {
    set {
      kdlPINVOKE.Frame_p_set(swigCPtr, Vector.getCPtr(value));
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = kdlPINVOKE.Frame_p_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Rotation M {
    set {
      kdlPINVOKE.Frame_M_set(swigCPtr, Rotation.getCPtr(value));
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = kdlPINVOKE.Frame_M_get(swigCPtr);
      Rotation ret = (cPtr == global::System.IntPtr.Zero) ? null : new Rotation(cPtr, false);
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Frame(Rotation R, Vector V) : this(kdlPINVOKE.new_Frame__SWIG_0(Rotation.getCPtr(R), Vector.getCPtr(V)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Frame(Vector V) : this(kdlPINVOKE.new_Frame__SWIG_1(Vector.getCPtr(V)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Frame(Rotation R) : this(kdlPINVOKE.new_Frame__SWIG_2(Rotation.getCPtr(R)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Frame() : this(kdlPINVOKE.new_Frame__SWIG_3(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Frame(Frame arg) : this(kdlPINVOKE.new_Frame__SWIG_4(Frame.getCPtr(arg)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Make4x4(SWIGTYPE_p_double d) {
    kdlPINVOKE.Frame_Make4x4(swigCPtr, SWIGTYPE_p_double.getCPtr(d));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Frame Inverse() {
    Frame ret = new Frame(kdlPINVOKE.Frame_Inverse__SWIG_0(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector Inverse(Vector arg) {
    Vector ret = new Vector(kdlPINVOKE.Frame_Inverse__SWIG_1(swigCPtr, Vector.getCPtr(arg)), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Wrench Inverse(Wrench arg) {
    Wrench ret = new Wrench(kdlPINVOKE.Frame_Inverse__SWIG_2(swigCPtr, Wrench.getCPtr(arg)), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Twist Inverse(Twist arg) {
    Twist ret = new Twist(kdlPINVOKE.Frame_Inverse__SWIG_3(swigCPtr, Twist.getCPtr(arg)), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Frame Identity() {
    Frame ret = new Frame(kdlPINVOKE.Frame_Identity(), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Integrate(Twist t_this, double frequency) {
    kdlPINVOKE.Frame_Integrate(swigCPtr, Twist.getCPtr(t_this), frequency);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Frame DH_Craig1989(double a, double alpha, double d, double theta) {
    Frame ret = new Frame(kdlPINVOKE.Frame_DH_Craig1989(a, alpha, d, theta), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Frame DH(double a, double alpha, double d, double theta) {
    Frame ret = new Frame(kdlPINVOKE.Frame_DH(a, alpha, d, theta), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
