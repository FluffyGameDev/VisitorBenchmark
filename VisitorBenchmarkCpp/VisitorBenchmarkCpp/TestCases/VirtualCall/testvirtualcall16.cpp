#include "testvirtualcall.h"

#include "../globalmacros.h"
#include "virtualcallmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::VirtualCall::Classes16
{
    DECLARE_VIRTUAL_CALL_BASE_UNIT();
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Artificer, Gun);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Barbarian, Sword);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Bard, Flute);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Boat, Cargo);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Cleric, Mace);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Dancer, Mojo);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Druid, AnimalForm);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Fighter, ShortSword);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Monk, Fist);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Ninja, Kunai);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Paladin, Faith);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Ranger, Bow);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Rogue, Dagger);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Sorcerer, Book);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Warlock, Patron);
    DECLARE_VIRTUAL_CALL_CHILD_UNIT(Wizard, Wand);

    std::vector<Unit*> g_Units;

    static void VirtualCallClasses16(benchmark::State& state)
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

    BENCHMARK(VirtualCallClasses16);
}

DEFINE_INIT_TEST_CASE_16_CLASSES(VirtualCall);