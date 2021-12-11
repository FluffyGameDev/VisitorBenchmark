#include <benchmark/benchmark.h>

#include "TestCases/IfElseIf/testifelseif.h"
#include "TestCases/NoVirtualSwitch/testnovirtualswitch.h"
#include "TestCases/VirtualCall/testvirtualcall.h"
#include "TestCases/VirtualSwitch/testvirtualswitch.h"
#include "TestCases/Visitor/testvisitor.h"

int main(int argc, char** argv)
{
    TestCase::IfElseIf::InitTest04Classes();
    TestCase::IfElseIf::InitTest08Classes();
    TestCase::IfElseIf::InitTest16Classes();

    TestCase::VirtualCall::InitTest04Classes();
    TestCase::VirtualCall::InitTest08Classes();
    TestCase::VirtualCall::InitTest16Classes();

    TestCase::Visitor::InitTest04Classes();
    TestCase::Visitor::InitTest08Classes();
    TestCase::Visitor::InitTest16Classes();

    TestCase::VirtualSwitch::InitTest04Classes();
    TestCase::VirtualSwitch::InitTest08Classes();
    TestCase::VirtualSwitch::InitTest16Classes();

    TestCase::NoVirtualSwitch::InitTest04Classes();
    TestCase::NoVirtualSwitch::InitTest08Classes();
    TestCase::NoVirtualSwitch::InitTest16Classes();

    ::benchmark::Initialize(&argc, argv);
    ::benchmark::RunSpecifiedBenchmarks();
    ::benchmark::Shutdown();
    return 0;
}