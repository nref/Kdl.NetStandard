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

public class VelocityProfile_Spline : VelocityProfile {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VelocityProfile_Spline(global::System.IntPtr cPtr, bool cMemoryOwn) : base(kdlPINVOKE.VelocityProfile_Spline_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VelocityProfile_Spline obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(VelocityProfile_Spline obj) {
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

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          kdlPINVOKE.delete_VelocityProfile_Spline(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public VelocityProfile_Spline() : this(kdlPINVOKE.new_VelocityProfile_Spline__SWIG_0(), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public VelocityProfile_Spline(VelocityProfile_Spline p) : this(kdlPINVOKE.new_VelocityProfile_Spline__SWIG_1(VelocityProfile_Spline.getCPtr(p)), true) {
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetProfile(double pos1, double pos2) {
    kdlPINVOKE.VelocityProfile_Spline_SetProfile(swigCPtr, pos1, pos2);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetProfileDuration(double pos1, double pos2, double duration) {
    kdlPINVOKE.VelocityProfile_Spline_SetProfileDuration__SWIG_0(swigCPtr, pos1, pos2, duration);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetProfileDuration(double pos1, double vel1, double pos2, double vel2, double duration) {
    kdlPINVOKE.VelocityProfile_Spline_SetProfileDuration__SWIG_1(swigCPtr, pos1, vel1, pos2, vel2, duration);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetProfileDuration(double pos1, double vel1, double acc1, double pos2, double vel2, double acc2, double duration) {
    kdlPINVOKE.VelocityProfile_Spline_SetProfileDuration__SWIG_2(swigCPtr, pos1, vel1, acc1, pos2, vel2, acc2, duration);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public override double Duration() {
    double ret = kdlPINVOKE.VelocityProfile_Spline_Duration(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Pos(double time) {
    double ret = kdlPINVOKE.VelocityProfile_Spline_Pos(swigCPtr, time);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Vel(double time) {
    double ret = kdlPINVOKE.VelocityProfile_Spline_Vel(swigCPtr, time);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Acc(double time) {
    double ret = kdlPINVOKE.VelocityProfile_Spline_Acc(swigCPtr, time);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Write(SWIGTYPE_p_std__ostream os) {
    kdlPINVOKE.VelocityProfile_Spline_Write(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

  public override VelocityProfile c_Clone() {
    global::System.IntPtr cPtr = kdlPINVOKE.VelocityProfile_Spline_c_Clone(swigCPtr);
    VelocityProfile ret = (cPtr == global::System.IntPtr.Zero) ? null : new VelocityProfile(cPtr, false);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
