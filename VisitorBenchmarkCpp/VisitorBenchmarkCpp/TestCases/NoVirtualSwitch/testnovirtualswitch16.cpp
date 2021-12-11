#include "testnovirtualswitch.h"

#include "../globalmacros.h"
#include "novirtualswitchmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::NoVirtualSwitch::Classes16
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
        Fighter,
        Monk,
        Ninja,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard
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
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Monk, Fist);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Ninja, Kunai);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Paladin, Faith);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Ranger, Bow);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Rogue, Dagger);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Sorcerer, Book);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Warlock, Patron);
    DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Wizard, Wand);

    std::vector<Unit*> g_Units;

    static void NoVirtualSwitchClasses16(benchmark::State& state)
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
                    NO_VIRTUAL_SWITCH_CASE(Monk, Fist);
                    NO_VIRTUAL_SWITCH_CASE(Ninja, Kunai);
                    NO_VIRTUAL_SWITCH_CASE(Paladin, Faith);
                    NO_VIRTUAL_SWITCH_CASE(Ranger, Bow);
                    NO_VIRTUAL_SWITCH_CASE(Rogue, Dagger);
                    NO_VIRTUAL_SWITCH_CASE(Sorcerer, Book);
                    NO_VIRTUAL_SWITCH_CASE(Warlock, Patron);
                    NO_VIRTUAL_SWITCH_CASE(Wizard, Wand);
                }
            }
        }
    }

    BENCHMARK(NoVirtualSwitchClasses16);
}

DEFINE_INIT_TEST_CASE_16_CLASSES(NoVirtualSwitch);