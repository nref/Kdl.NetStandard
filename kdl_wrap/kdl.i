%module(directors="1") kdl

%include <typemaps.i>

// https://swig.org/Doc4.1/Arguments.html
// Map all C++ "double&" (double reference parameters) to "ref double" in C#
//apply double &INOUT { double& };

// Map all "double&" parameters to "out double" in C#
%apply double &OUTPUT { double& };

// Map only "double& foo" (double reference parameters named "foo") to "out double foo"
//%apply double &OUTPUT { double& foo };

// Clear the %apply directive for the given type:
//%clear double& foo

// Example:
// frames.hpp:
// // in Rotation class
// inline void GetEulerZYX(double& Alfa,double& Beta,double& Gamma) const { ... }
//
// Rotation.cs:
//
// public void GetEulerZYX(out double Alfa, out double Beta, out double Gamma) {

%{

#define EIGEN_NO_DEPRECATED_WARNING

#include "config.h"
#include "utilities/kdl-config.h"
#include "utilities/utility.h"
#include "utilities/rall1d.h"
#include "utilities/rall2d.h"
#include "utilities/traits.h"
#include "velocityprofile.hpp"
#include "velocityprofile_spline.hpp"
#include "velocityprofile_trap.hpp"
#include "Properties.h"
#include "frames.hpp"
#include "framevel.hpp"
#include "frameacc.hpp"
#include "joint.hpp"
#include "jacobian.hpp"
#include "jntarray.hpp"
#include "jntarrayvel.hpp"
#include "jntarrayacc.hpp"
#include "rigidbodyinertia.hpp"
#include "segment.hpp"
#include "chain.hpp"
#include "solveri.hpp"
#include "chainjnttojacsolver.hpp"
#include "chainfksolver.hpp"
#include "chainiksolver.hpp"
#include "chainfksolverpos_recursive.hpp"
#include "chainiksolverpos_nr_jl.hpp"
#include "chainfksolvervel_recursive.hpp"
#include "chainiksolverpos_lma.hpp"
#include "chainiksolvervel_pinv.hpp"
#include "chainiksolvervel_wdls.hpp"

int KDL::VSIZE = 0;
using namespace KDL;

%}

%include "std_string.i"

%include "exception.i"
%allowexception;
%exception {
  try {
    $action
  } catch (const std::exception& e) {
    SWIG_exception(SWIG_RuntimeError, e.what());
  }
}

%extend KDL::JntArray {

  double get(int index) {
    return (*$self)(index, 0);
  }

  void set(int index, double value) {
    double& elem = (*$self)(index, 0);
    elem = value;
  }
}

%include "std_vector.i"

%template(FrameVector) std::vector<KDL::Frame>;
%template(FrameVelVector) std::vector<KDL::FrameVel>;
%template(FrameAccVector) std::vector<KDL::FrameAcc>;
%template(SegmentVector) std::vector<KDL::Segment>;
%template(BoolVector) std::vector<bool>;

%ignore KDL::JntArray::data;
%ignore KDL::Frame2;
%ignore KDL::ChainIkSolverPos_LMA::compute_fwdpos;
%ignore KDL::ChainIkSolverPos_LMA::compute_jacobian;
%ignore KDL::ChainIkSolverPos_LMA::lastSV;
%ignore KDL::ChainIkSolverPos_LMA::grad;
%ignore KDL::ChainIkSolverPos_LMA::jac;


#define _MSC_VER 1926
#define EIGEN_NO_DEPRECATED_WARNING
 
#undef EIGEN_DEVICE_FUNC
#define EIGEN_DEVICE_FUNC /**/
#define EIGEN_STRONG_INLINE __forceinline

%include "config.h"
%include "utilities/kdl-config.h"
%include "utilities/utility.h"

#undef INLINE
%define INLINE __forceinline

// "%import simply gathers type information, but doesn't generate wrappers."
// http://www.swig.org/Doc4.0/SWIGDocumentation.html
%import "utilities/rall1d.h"
%import "utilities/rall2d.h"

%template(doubleVel) Rall1d<double>;
%template(doubleAcc) Rall2d<double,double,double>;
%include "utilities/rall1d.h"
%include "utilities/rall2d.h"
%enddef

%include "velocityprofile.hpp"
%include "velocityprofile_spline.hpp"
%include "velocityprofile_trap.hpp"

#undef IMETHOD
#define IMETHOD /**/
%include "frames.hpp"
%include "Properties.h"
%include "framevel.hpp"
%include "frameacc.hpp"
%include "joint.hpp"
%include "jacobian.hpp"
%include "jntarray.hpp"
%include "jntarrayvel.hpp"
%include "jntarrayacc.hpp"
%include "rotationalinertia.hpp"
%include "rigidbodyinertia.hpp"
%include "segment.hpp"
%include "chain.hpp"
%include "solveri.hpp"
%include "chainjnttojacsolver.hpp"
%include "chainfksolver.hpp"
%include "chainiksolver.hpp"
%include "chainfksolverpos_recursive.hpp"
%include "chainiksolverpos_nr_jl.hpp"
%include "chainfksolvervel_recursive.hpp"
%include "chainiksolverpos_lma.hpp"
%include "chainiksolvervel_pinv.hpp"
%include "chainiksolvervel_wdls.hpp"
