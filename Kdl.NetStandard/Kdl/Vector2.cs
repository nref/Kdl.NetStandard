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

public class Vector2 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Vector2(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vector2() {
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
          kdlPINVOKE.delete_Vector2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Vector2() : this(kdlPINVOKE.new_Vector2__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2(double x, double y) : this(kdlPINVOKE.new_Vector2__SWIG_1(x, y), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2(Vector2 arg) : this(kdlPINVOKE.new_Vector2__SWIG_2(Vector2.getCPtr(arg)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public double x() {
    double ret = kdlPINVOKE.Vector2_x__SWIG_0(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double y() {
    double ret = kdlPINVOKE.Vector2_y__SWIG_0(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void x(double arg0) {
    kdlPINVOKE.Vector2_x__SWIG_1(swigCPtr, arg0);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void y(double arg0) {
    kdlPINVOKE.Vector2_y__SWIG_1(swigCPtr, arg0);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReverseSign() {
    kdlPINVOKE.Vector2_ReverseSign(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Vector2 Zero() {
    Vector2 ret = new Vector2(kdlPINVOKE.Vector2_Zero(), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Normalize(double eps) {
    double ret = kdlPINVOKE.Vector2_Normalize__SWIG_0(swigCPtr, eps);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Normalize() {
    double ret = kdlPINVOKE.Vector2_Normalize__SWIG_1(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Norm() {
    double ret = kdlPINVOKE.Vector2_Norm(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set3DXY(Vector v) {
    kdlPINVOKE.Vector2_Set3DXY(swigCPtr, Vector.getCPtr(v));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set3DYZ(Vector v) {
    kdlPINVOKE.Vector2_Set3DYZ(swigCPtr, Vector.getCPtr(v));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set3DZX(Vector v) {
    kdlPINVOKE.Vector2_Set3DZX(swigCPtr, Vector.getCPtr(v));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set3DPlane(Frame F_someframe_XY, Vector v_someframe) {
    kdlPINVOKE.Vector2_Set3DPlane(swigCPtr, Frame.getCPtr(F_someframe_XY), Vector.getCPtr(v_someframe));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
