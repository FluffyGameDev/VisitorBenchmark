cmake_minimum_required (VERSION 3.8)

add_executable (VisitorBenchmarkCpp "main.cpp"
                                    "TestCases/IfElseIf/testifelseif04.cpp"
                                    "TestCases/IfElseIf/testifelseif08.cpp"
                                    "TestCases/IfElseIf/testifelseif16.cpp"
                                    "TestCases/VirtualCall/testvirtualcall04.cpp"
                                    "TestCases/VirtualCall/testvirtualcall08.cpp"
                                    "TestCases/VirtualCall/testvirtualcall16.cpp"
                                    "TestCases/Visitor/testvisitor04.cpp"
                                    "TestCases/Visitor/testvisitor08.cpp"
                                    "TestCases/Visitor/testvisitor16.cpp"
                                    "TestCases/VirtualSwitch/testvirtualswitch04.cpp"
                                    "TestCases/VirtualSwitch/testvirtualswitch08.cpp"
                                    "TestCases/VirtualSwitch/testvirtualswitch16.cpp"
                                    "TestCases/NoVirtualSwitch/testnovirtualswitch04.cpp"
                                    "TestCases/NoVirtualSwitch/testnovirtualswitch08.cpp"
                                    "TestCases/NoVirtualSwitch/testnovirtualswitch16.cpp"
                                    )

target_link_libraries(VisitorBenchmarkCpp benchmark::benchmark)

set_property(TARGET VisitorBenchmarkCpp PROPERTY CXX_STANDARD 17)