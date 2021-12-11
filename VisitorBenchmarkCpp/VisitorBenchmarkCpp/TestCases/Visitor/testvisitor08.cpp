#include "testvisitor.h"

#include "../globalmacros.h"
#include "visitormacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::Visitor::Classes08
{
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Artificer);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Barbarian);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Bard);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Boat);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Cleric);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Dancer);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Druid);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Fighter);

    class UnitVisitor
    {
    public:
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Artificer);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Barbarian);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Bard);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Boat);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Cleric);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Dancer);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Druid);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Fighter);
    };

    DECLARE_VISITOR_BASE_UNIT();
    DECLARE_VISITOR_CHILD_UNIT(Artificer, Gun);
    DECLARE_VISITOR_CHILD_UNIT(Barbarian, Sword);
    DECLARE_VISITOR_CHILD_UNIT(Bard, Flute);
    DECLARE_VISITOR_CHILD_UNIT(Boat, Cargo);
    DECLARE_VISITOR_CHILD_UNIT(Cleric, Mace);
    DECLARE_VISITOR_CHILD_UNIT(Dancer, Mojo);
    DECLARE_VISITOR_CHILD_UNIT(Druid, AnimalForm);
    DECLARE_VISITOR_CHILD_UNIT(Fighter, ShortSword);

    class DamageUnitVisitor : public UnitVisitor
    {
    public:
        int m_TotalDamage{};

        DECLARE_VISITOR_IMPL_FUNCTION(Artificer, Gun);
        DECLARE_VISITOR_IMPL_FUNCTION(Barbarian, Sword);
        DECLARE_VISITOR_IMPL_FUNCTION(Bard, Flute);
        DECLARE_VISITOR_IMPL_FUNCTION(Boat, Cargo);
        DECLARE_VISITOR_IMPL_FUNCTION(Cleric, Mace);
        DECLARE_VISITOR_IMPL_FUNCTION(Dancer, Mojo);
        DECLARE_VISITOR_IMPL_FUNCTION(Druid, AnimalForm);
        DECLARE_VISITOR_IMPL_FUNCTION(Fighter, ShortSword);
    };

    std::vector<Unit*> g_Units;

    static void VisitorClasses08(benchmark::State& state)
    {
        for (auto _ : state)
        {
            DamageUnitVisitor visitor;
            int totalDamage{};

            for (const Unit* unit : g_Units)
            {
                unit->Accept(visitor);
            }
        }
    }

    BENCHMARK(VisitorClasses08);
}

DEFINE_INIT_TEST_CASE_08_CLASSES(Visitor);