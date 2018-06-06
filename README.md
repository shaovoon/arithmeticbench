# Floating Point and Integer Arithmetic Benchmark

All the integer and double types used in Benchmark are 64bit. Timing is based on looping 100 million times. Clarification: SmallInt and SmallDouble refers to small values (10-10000) stored in int64_t and double, not refering to the type size. Big integer and double value range from 10,000 to 1000,000, if they are any bigger, there would be overflow in 64bit integer.

## Hardware Specs

* __Processor:__ Intel i7-6700 CPU @ 3.40GHz, 3400 Mhz, 4 Cores, 8 Logical Processors
* __RAM:__ 16 GB
* __Graphics Card:__ NVIDIA GeForce GTX 1060 6GB

## CSharp x64 Benchmark 

Note: x86-32 executable typically has worse integer performance than floating point(not shown here); You can build as x86-32 executable and run it to see for yourself.

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

The performance of floating point arithmetic has caught up with the integer in the last 15 years. This very much removes the requirement to having our own custom fixed point type to wrench the last drop of performance out of processor. For those who are not familiar, fixed point is arithmetic type which is like floating point except its decimal point is fixed, does not move, hence its name. The main difference is fixed point arithmetic is executed on the integer unit, not on floating point unit. Fixed point type was relevant during the period where integer perf was crown over floating point.

Any suggestion on how to improve the nature of benchmark or constructive criticism on what I have been doing wrong, is all welcome.