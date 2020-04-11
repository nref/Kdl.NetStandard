%module(directors="1") kdl

%{

#include "config.h"
#include "utilities/utility.h"
#include "utilities/rall1d.h"
#include "utilities/rall2d.h"
#include "utilities/traits.h"
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
#include "chainiksolver.hpp"
#include "chainiksolverpos_nr_jl.hpp"

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

// Ignore this macro
%define EIGEN_MAKE_ALIGNED_OPERATOR_NEW(x) 0

%include "config.h"
%include "utilities/utility.h"
%include "utilities/rall1d.h"
%include "utilities/rall2d.h"
%include "utilities/traits.h"
%include "frames.hpp"
%include "framevel.hpp"
%include "frameacc.hpp"
%include "joint.hpp"
%include "jacobian.hpp"
%include "jntarray.hpp"
%include "jntarrayvel.hpp"
%include "jntarrayacc.hpp"
%include "rigidbodyinertia.hpp"
%include "segment.hpp"
%include "chain.hpp"
%include "solveri.hpp"
%include "chainiksolver.hpp"
%include "chainiksolverpos_nr_jl.hpp"

%enddef // EIGEN_MAKE_ALIGNED_OPERATOR_NEW