# Floating Point and Integer Arithmetic Benchmark

All the integer and double types used in Benchmark are 64bit. Timing is based on looping 100 million times. Clarification: SmallInt and SmallDouble refers to small values stored in int64_t and double, not the types.

## CSharp x64 Benchmark 

Note: x86-32 executable typically has worse integer performance than floating point(not shown here).

```
Multiplication and Division Benchmark
=====================================
MulBigDouble RunTime:00:00.186
MulBigInt RunTime:00:00.157
DivBigDouble RunTime:00:00.160
DivBigInt RunTime:00:00.776
MulSmallDouble RunTime:00:00.192
MulSmallInt RunTime:00:00.191
DivSmallDouble RunTime:00:00.205
DivSmallInt RunTime:00:00.933

Addition and Subtraction Benchmark
==================================
AddBigDouble RunTime:00:00.167
AddBigInt RunTime:00:00.154
SubBigDouble RunTime:00:00.151
SubBigInt RunTime:00:00.152
AddSmallDouble RunTime:00:00.204
AddSmallInt RunTime:00:00.187
SubSmallDouble RunTime:00:00.186
SubSmallInt RunTime:00:00.218
```

## C++ x64 Benchmark

```
Multiplication and Division Benchmark
=====================================
       MulBigDouble:   57ms
          MulBigInt:   49ms
       DivBigDouble:   96ms
          DivBigInt:  636ms
     MulSmallDouble:   60ms
        MulSmallInt:   68ms
     DivSmallDouble:  118ms
        DivSmallInt:  823ms

Addition and Subtraction Benchmark
==================================
       AddBigDouble:   57ms
          AddBigInt:   49ms
       SubBigDouble:   64ms
          SubBigInt:   49ms
     AddSmallDouble:   69ms
        AddSmallInt:   59ms
     SubSmallDouble:   63ms
        SubSmallInt:   59ms
```

Most of the time, integer performance is on par with floating point, with exception of division.

The performance of floating point arithmetic has caught up with the integer in the last 15 years. This very much removes the requirement to having our own custom fixed point type to wrench the last drop of performance out of processor.