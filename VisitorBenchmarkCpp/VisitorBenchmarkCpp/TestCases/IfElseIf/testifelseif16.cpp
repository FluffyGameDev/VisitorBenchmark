#include "testifelseif.h"

#include "../globalmacros.h"
#include "ifelseifmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::IfElseIf::Classes16
{
    DECLARE_IF_ELSE_IF_BASE_UNIT();
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Artificer, Gun);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Barbarian, Sword);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Bard, Flute);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Boat, Cargo);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Cleric, Mace);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Dancer, Mojo);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Druid, AnimalForm);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Fighter, ShortSword);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Monk, Fist);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Ninja, Kunai);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Paladin, Faith);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Ranger, Bow);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Rogue, Dagger);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Sorcerer, Book);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Warlock, Patron);
    DECLARE_IF_ELSE_IF_CHILD_UNIT(Wizard, Wand);

    std::vector<Unit*> g_Units;

    static void IfElseIfClasses16(benchmark::State& state)
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
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Cleric, Mace)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Dancer, Mojo)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Druid, AnimalForm)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Fighter, ShortSword)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Monk, Fist)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Ninja, Kunai)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Paladin, Faith)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Ranger, Bow)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Rogue, Dagger)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Sorcerer, Book)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Warlock, Patron)
                else IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Wizard, Wand)
            }
        }
    }

    BENCHMARK(IfElseIfClasses16);
}

DEFINE_INIT_TEST_CASE_16_CLASSES(IfElseIf);