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

public class ChainFkSolverPos : SolverI {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChainFkSolverPos(global::System.IntPtr cPtr, bool cMemoryOwn) : base(kdlPINVOKE.ChainFkSolverPos_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChainFkSolverPos obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ChainFkSolverPos obj) {
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
          kdlPINVOKE.delete_ChainFkSolverPos(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual int JntToCart(JntArray q_in, Frame p_out, int segmentNr) {
    int ret = kdlPINVOKE.ChainFkSolverPos_JntToCart__SWIG_0(swigCPtr, JntArray.getCPtr(q_in), Frame.getCPtr(p_out), segmentNr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int JntToCart(JntArray q_in, Frame p_out) {
    int ret = kdlPINVOKE.ChainFkSolverPos_JntToCart__SWIG_1(swigCPtr, JntArray.getCPtr(q_in), Frame.getCPtr(p_out));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int JntToCart(JntArray q_in, FrameVector p_out, int segmentNr) {
    int ret = kdlPINVOKE.ChainFkSolverPos_JntToCart__SWIG_2(swigCPtr, JntArray.getCPtr(q_in), FrameVector.getCPtr(p_out), segmentNr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int JntToCart(JntArray q_in, FrameVector p_out) {
    int ret = kdlPINVOKE.ChainFkSolverPos_JntToCart__SWIG_3(swigCPtr, JntArray.getCPtr(q_in), FrameVector.getCPtr(p_out));
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void updateInternalDataStructures() {
    kdlPINVOKE.ChainFkSolverPos_updateInternalDataStructures(swigCPtr);
    if (kdlPINVOKE.SWIGPendingException.Pending) throw kdlPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
