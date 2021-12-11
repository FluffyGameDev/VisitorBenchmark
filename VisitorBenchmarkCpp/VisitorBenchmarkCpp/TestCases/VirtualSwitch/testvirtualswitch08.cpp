#include "testvirtualswitch.h"

#include "../globalmacros.h"
#include "virtualswitchmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::VirtualSwitch::Classes08
{
    enum class UnitType
    {
        Artificer,
        Barbarian,
        Bard,
        Boat,
        Cleric,
        Dancer,
        Druid,
        Fighter
    };

    DECLARE_VIRTUAL_SWITCH_BASE_UNIT();
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Artificer, Gun);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Barbarian, Sword);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Bard, Flute);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Boat, Cargo);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Cleric, Mace);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Dancer, Mojo);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Druid, AnimalForm);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Fighter, ShortSword);

    std::vector<Unit*> g_Units;

    static void VirtualSwitchClasses08(benchmark::State& state)
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
                    VIRTUAL_SWITCH_CASE(Cleric, Mace);
                    VIRTUAL_SWITCH_CASE(Dancer, Mojo);
                    VIRTUAL_SWITCH_CASE(Druid, AnimalForm);
                    VIRTUAL_SWITCH_CASE(Fighter, ShortSword);
                }
            }
        }
    }

    BENCHMARK(VirtualSwitchClasses08);
}

DEFINE_INIT_TEST_CASE_08_CLASSES(VirtualSwitch);