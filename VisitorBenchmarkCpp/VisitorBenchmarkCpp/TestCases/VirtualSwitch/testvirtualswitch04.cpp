#include "testvirtualswitch.h"

#include "../globalmacros.h"
#include "virtualswitchmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::VirtualSwitch::Classes04
{
    enum class UnitType
    {
        Artificer,
        Barbarian,
        Bard,
        Boat
    };

    DECLARE_VIRTUAL_SWITCH_BASE_UNIT();
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Artificer, Gun);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Barbarian, Sword);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Bard, Flute);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Boat, Cargo);

    std::vector<Unit*> g_Units;

    static void VirtualSwitchClasses04(benchmark::State& state)
    {
        for (auto _ : state)
        {
            int totalDamage{};

            for (const Unit* unit : g_Units)
            {
                switch (unit->GetUnitType())
                {
                    VIRTUAL_SWITCH_CASE(Artificer, Gun);
                    VIRTUAL_SWITCH_CASE(Barbarian, Sword);
                    VIRTUAL_SWITCH_CASE(Bard, Flute);
                    VIRTUAL_SWITCH_CASE(Boat, Cargo);
                }
            }
        }
    }

    BENCHMARK(VirtualSwitchClasses04);
}

DEFINE_INIT_TEST_CASE_04_CLASSES(VirtualSwitch);