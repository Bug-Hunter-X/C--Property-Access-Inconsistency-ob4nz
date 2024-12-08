# C# Property Access Inconsistency Bug

This repository demonstrates a subtle bug in C# related to accessing properties multiple times within a method. The issue arises when a property's value is modified within the method, and subsequent accesses to the property don't reflect the updated value, especially if compiler optimizations or caching are involved.

## Description
The bug showcases how accessing a property multiple times within a method can lead to incorrect results due to compiler optimizations or caching mechanisms. This is particularly noticeable when the property's value is modified between accesses, but the later access still shows the old value.

## Reproduction Steps
1. Clone this repository.
2. Compile and run `BuggyPropertyAccess.cs`.
3. Observe the inconsistent results. 
4. Compare with the fixed version in `CorrectedPropertyAccess.cs`

## Solution
The solution involves avoiding the potential caching issues by accessing the property's value only when needed.  If you need to store the value, use a local variable instead of relying on repeated property access. 