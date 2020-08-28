%module(directors="1") kdl

%{

#define EIGEN_NO_DEPRECATED_WARNING

#include "config.h"
#include "utilities/kdl-config.h"
#include "utilities/utility.h"
#include "utilities/rall1d.h"
#include "utilities/rall2d.h"
#include "utilities/traits.h"
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

// Pass std::exception up to C#
%include "exception.i"
%allowexception;
%exception {
  try {
    $action
  } catch (const std::exception& e) {
    SWIG_exception(SWIG_RuntimeError, e.what());
  }
}

%include "cpointer.i"
%pointer_class(double, DoublePointer);

%rename(get) KDL::JntArray::operator()(unsigned int i,unsigned int j=0) const;
%rename(pointer) KDL::JntArray::operator()(unsigned int i,unsigned int j=0);
%rename(get) KDL::JntArrayVel::operator()(unsigned int i,unsigned int j=0) const;
%rename(pointer) KDL::JntArrayVel::operator()(unsigned int i,unsigned int j=0);

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
