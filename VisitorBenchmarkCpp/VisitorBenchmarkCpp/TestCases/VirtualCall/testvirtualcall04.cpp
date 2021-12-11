#include "testvirtualcall.h"

#include "../globalmacros.h"
#include "virtualcallmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::VirtualCall::Classes04
{
    DECLARE_VIRTUAL_CALL_BASE_UNIT();
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Artificer, Gun);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Barbarian, Sword);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Bard, Flute);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Boat, Cargo);

    std::vector<Unit*> g_Units;

    static void VirtualCallClasses04(benchmark::State& state)
    {
        for (auto _ : state)
        {
            int totalDamage{};

            for (const Unit* unit : g_Units)
            {
                totalDamage += unit->ComputeDamage();
            }
        }
    }

    BENCHMARK(VirtualCallClasses04);
}

DEFINE_INIT_TEST_CASE_04_CLASSES(VirtualCall);