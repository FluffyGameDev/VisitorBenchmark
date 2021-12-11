#include "testifelseif.h"

#include "../globalmacros.h"
#include "ifelseifmacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::IfElseIf::Classes08
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

    std::vector<Unit*> g_Units;

    static void IfElseIfClasses08(benchmark::State& state)
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
            }
        }
    }

    BENCHMARK(IfElseIfClasses08);
}

DEFINE_INIT_TEST_CASE_08_CLASSES(IfElseIf);