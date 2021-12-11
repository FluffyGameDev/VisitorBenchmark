#include "testnovirtualswitch.h"

#include "../globalmacros.h"
#include "novirtualswitchmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::NoVirtualSwitch::Classes08
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

    DECLARE_NO_VIRTUAL_SWITCH_BASE_UNIT();
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Artificer, Gun);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Barbarian, Sword);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Bard, Flute);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Boat, Cargo);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Cleric, Mace);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Dancer, Mojo);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Druid, AnimalForm);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Fighter, ShortSword);

    std::vector<Unit*> g_Units;

    static void NoVirtualSwitchClasses08(benchmark::State& state)
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
                    NO_VIRTUAL_SWITCH_CASE(Cleric, Mace);
                    NO_VIRTUAL_SWITCH_CASE(Dancer, Mojo);
                    NO_VIRTUAL_SWITCH_CASE(Druid, AnimalForm);
                    NO_VIRTUAL_SWITCH_CASE(Fighter, ShortSword);
                }
            }
        }
    }

    BENCHMARK(NoVirtualSwitchClasses08);
}

DEFINE_INIT_TEST_CASE_08_CLASSES(NoVirtualSwitch);