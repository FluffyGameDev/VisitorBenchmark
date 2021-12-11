#include "testnovirtualswitch.h"

#include "../globalmacros.h"
#include "novirtualswitchmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::NoVirtualSwitch::Classes04
{
    enum class UnitType
    {
        Artificer,
        Barbarian,
        Bard,
        Boat
    };

    DECLARE_NO_VIRTUAL_SWITCH_BASE_UNIT();
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Artificer, Gun);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Barbarian, Sword);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Bard, Flute);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Boat, Cargo);

    std::vector<Unit*> g_Units;

    static void NoVirtualSwitchClasses04(benchmark::State& state)
    {
        for (auto _ : state)
        {
            int totalDamage{};

            for (const Unit* unit : g_Units)
            {
                switch (unit->GetUnitType())
                {
                    NO_VIRTUAL_SWITCH_CASE(Artificer, Gun);
                    NO_VIRTUAL_SWITCH_CASE(Barbarian, Sword);
                    NO_VIRTUAL_SWITCH_CASE(Bard, Flute);
                    NO_VIRTUAL_SWITCH_CASE(Boat, Cargo);
                }
            }
        }
    }

    BENCHMARK(NoVirtualSwitchClasses04);
}

DEFINE_INIT_TEST_CASE_04_CLASSES(NoVirtualSwitch);