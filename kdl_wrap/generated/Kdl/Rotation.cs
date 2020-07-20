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

public class Rotation : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Rotation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Rotation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Rotation() {
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
          kdlPINVOKE.delete_Rotation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_double data {
    set {
      kdlPINVOKE.Rotation_data_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = kdlPINVOKE.Rotation_data_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Rotation() : this(kdlPINVOKE.new_Rotation__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation(double Xx, double Yx, double Zx, double Xy, double Yy, double Zy, double Xz, double Yz, double Zz) : this(kdlPINVOKE.new_Rotation__SWIG_1(Xx, Yx, Zx, Xy, Yy, Zy, Xz, Yz, Zz), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation(Vector x, Vector y, Vector z) : this(kdlPINVOKE.new_Rotation__SWIG_2(Vector.getCPtr(x), Vector.getCPtr(y), Vector.getCPtr(z)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation(Rotation arg) : this(kdlPINVOKE.new_Rotation__SWIG_3(Rotation.getCPtr(arg)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetInverse() {
    kdlPINVOKE.Rotation_SetInverse(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation Inverse() {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_Inverse__SWIG_0(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector Inverse(Vector v) {
    Vector ret = new Vector(kdlPINVOKE.Rotation_Inverse__SWIG_1(swigCPtr, Vector.getCPtr(v)), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Wrench Inverse(Wrench arg) {
    Wrench ret = new Wrench(kdlPINVOKE.Rotation_Inverse__SWIG_2(swigCPtr, Wrench.getCPtr(arg)), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Twist Inverse(Twist arg) {
    Twist ret = new Twist(kdlPINVOKE.Rotation_Inverse__SWIG_3(swigCPtr, Twist.getCPtr(arg)), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Rotation Identity() {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_Identity(), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Rotation RotX(double angle) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_RotX(angle), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Rotation RotY(double angle) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_RotY(angle), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Rotation RotZ(double angle) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_RotZ(angle), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DoRotX(double angle) {
    kdlPINVOKE.Rotation_DoRotX(swigCPtr, angle);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DoRotY(double angle) {
    kdlPINVOKE.Rotation_DoRotY(swigCPtr, angle);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DoRotZ(double angle) {
    kdlPINVOKE.Rotation_DoRotZ(swigCPtr, angle);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Rotation Rot(Vector rotvec, double angle) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_Rot(Vector.getCPtr(rotvec), angle), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Rotation Rot2(Vector rotvec, double angle) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_Rot2(Vector.getCPtr(rotvec), angle), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector GetRot() {
    Vector ret = new Vector(kdlPINVOKE.Rotation_GetRot(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRotAngle(Vector axis, double eps) {
    double ret = kdlPINVOKE.Rotation_GetRotAngle__SWIG_0(swigCPtr, Vector.getCPtr(axis), eps);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetRotAngle(Vector axis) {
    double ret = kdlPINVOKE.Rotation_GetRotAngle__SWIG_1(swigCPtr, Vector.getCPtr(axis));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Rotation EulerZYZ(double Alfa, double Beta, double Gamma) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_EulerZYZ(Alfa, Beta, Gamma), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetEulerZYZ(SWIGTYPE_p_double alpha, SWIGTYPE_p_double beta, SWIGTYPE_p_double gamma) {
    kdlPINVOKE.Rotation_GetEulerZYZ(swigCPtr, SWIGTYPE_p_double.getCPtr(alpha), SWIGTYPE_p_double.getCPtr(beta), SWIGTYPE_p_double.getCPtr(gamma));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Rotation Quaternion(double x, double y, double z, double w) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_Quaternion(x, y, z, w), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetQuaternion(SWIGTYPE_p_double x, SWIGTYPE_p_double y, SWIGTYPE_p_double z, SWIGTYPE_p_double w) {
    kdlPINVOKE.Rotation_GetQuaternion(swigCPtr, SWIGTYPE_p_double.getCPtr(x), SWIGTYPE_p_double.getCPtr(y), SWIGTYPE_p_double.getCPtr(z), SWIGTYPE_p_double.getCPtr(w));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Rotation RPY(double roll, double pitch, double yaw) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_RPY(roll, pitch, yaw), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetRPY(SWIGTYPE_p_double roll, SWIGTYPE_p_double pitch, SWIGTYPE_p_double yaw) {
    kdlPINVOKE.Rotation_GetRPY(swigCPtr, SWIGTYPE_p_double.getCPtr(roll), SWIGTYPE_p_double.getCPtr(pitch), SWIGTYPE_p_double.getCPtr(yaw));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Rotation EulerZYX(double Alfa, double Beta, double Gamma) {
    Rotation ret = new Rotation(kdlPINVOKE.Rotation_EulerZYX(Alfa, Beta, Gamma), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetEulerZYX(SWIGTYPE_p_double Alfa, SWIGTYPE_p_double Beta, SWIGTYPE_p_double Gamma) {
    kdlPINVOKE.Rotation_GetEulerZYX(swigCPtr, SWIGTYPE_p_double.getCPtr(Alfa), SWIGTYPE_p_double.getCPtr(Beta), SWIGTYPE_p_double.getCPtr(Gamma));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector UnitX() {
    Vector ret = new Vector(kdlPINVOKE.Rotation_UnitX__SWIG_0(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnitX(Vector X) {
    kdlPINVOKE.Rotation_UnitX__SWIG_1(swigCPtr, Vector.getCPtr(X));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector UnitY() {
    Vector ret = new Vector(kdlPINVOKE.Rotation_UnitY__SWIG_0(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnitY(Vector X) {
    kdlPINVOKE.Rotation_UnitY__SWIG_1(swigCPtr, Vector.getCPtr(X));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector UnitZ() {
    Vector ret = new Vector(kdlPINVOKE.Rotation_UnitZ__SWIG_0(swigCPtr), true);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnitZ(Vector X) {
    kdlPINVOKE.Rotation_UnitZ__SWIG_1(swigCPtr, Vector.getCPtr(X));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
