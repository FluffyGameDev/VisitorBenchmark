#include "testvirtualswitch.h"

#include "../globalmacros.h"
#include "virtualswitchmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::VirtualSwitch::Classes16
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

    DECLARE_VIRTUAL_SWITCH_BASE_UNIT();
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Artificer, Gun);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Barbarian, Sword);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Bard, Flute);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Boat, Cargo);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Cleric, Mace);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Dancer, Mojo);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Druid, AnimalForm);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Fighter, ShortSword);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Monk, Fist);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Ninja, Kunai);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Paladin, Faith);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Ranger, Bow);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Rogue, Dagger);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Sorcerer, Book);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Warlock, Patron);
    DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Wizard, Wand);

    std::vector<Unit*> g_Units;

    static void VirtualSwitchClasses16(benchmark::State& state)
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
                    VIRTUAL_SWITCH_CASE(Monk, Fist);
                    VIRTUAL_SWITCH_CASE(Ninja, Kunai);
                    VIRTUAL_SWITCH_CASE(Paladin, Faith);
                    VIRTUAL_SWITCH_CASE(Ranger, Bow);
                    VIRTUAL_SWITCH_CASE(Rogue, Dagger);
                    VIRTUAL_SWITCH_CASE(Sorcerer, Book);
                    VIRTUAL_SWITCH_CASE(Warlock, Patron);
                    VIRTUAL_SWITCH_CASE(Wizard, Wand);
                }
            }
        }
    }

    BENCHMARK(VirtualSwitchClasses16);
}

DEFINE_INIT_TEST_CASE_16_CLASSES(VirtualSwitch);