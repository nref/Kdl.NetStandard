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

public class Rotation2 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Rotation2(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Rotation2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(Rotation2 obj) {
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

  ~Rotation2() {
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
          kdlPINVOKE.delete_Rotation2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Rotation2() : this(kdlPINVOKE.new_Rotation2__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation2(double angle_rad) : this(kdlPINVOKE.new_Rotation2__SWIG_1(angle_rad), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation2(double ca, double sa) : this(kdlPINVOKE.new_Rotation2__SWIG_2(ca, sa), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation2(Rotation2 arg) : this(kdlPINVOKE.new_Rotation2__SWIG_3(Rotation2.getCPtr(arg)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetInverse() {
    kdlPINVOKE.Rotation2_SetInverse(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation2 Inverse() {
    Rotation2 ret = new Rotation2(kdlPINVOKE.Rotation2_Inverse__SWIG_0(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector2 Inverse(Vector2 v) {
    Vector2 ret = new Vector2(kdlPINVOKE.Rotation2_Inverse__SWIG_1(swigCPtr, Vector2.getCPtr(v)), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetIdentity() {
    kdlPINVOKE.Rotation2_SetIdentity(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Rotation2 Identity() {
    Rotation2 ret = new Rotation2(kdlPINVOKE.Rotation2_Identity(), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRot(double angle) {
    kdlPINVOKE.Rotation2_SetRot(swigCPtr, angle);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Rotation2 Rot(double angle) {
    Rotation2 ret = new Rotation2(kdlPINVOKE.Rotation2_Rot(angle), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRot() {
    double ret = kdlPINVOKE.Rotation2_GetRot(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
