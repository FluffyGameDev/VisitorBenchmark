#include "testifelseif.h"

#include "../globalmacros.h"
#include "ifelseifmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::IfElseIf::Classes04
{
    DECLARE_IF_ELSE_IF_BASE_UNIT();
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Artificer, Gun);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Barbarian, Sword);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Bard, Flute);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Boat, Cargo);

    std::vector<Unit*> g_Units;

    static void IfElseIfClasses04(benchmark::State& state)
    {
        for (auto _ : state)
        {
            int totalDamage{};

            for (const Unit* unit : g_Units)
            {
                IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Artificer, Gun)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Barbarian, Sword)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Bard, Flute)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Boat, Cargo)
            }
        }
    }

    BENCHMARK(IfElseIfClasses04);
}

DEFINE_INIT_TEST_CASE_04_CLASSES(IfElseIf);