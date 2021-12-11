#include "testvisitor.h"

#include "../globalmacros.h"
#include "visitormacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::Visitor::Classes04
{
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Artificer);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Barbarian);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Bard);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Boat);

    class UnitVisitor
    {
    public:
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Artificer);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Barbarian);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Bard);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Boat);
    };

    DECLARE_VISITOR_BASE_UNIT();
    DECLARE_VISITOR_CHILD_UNIT(Artificer, Gun);
    DECLARE_VISITOR_CHILD_UNIT(Barbarian, Sword);
    DECLARE_VISITOR_CHILD_UNIT(Bard, Flute);
    DECLARE_VISITOR_CHILD_UNIT(Boat, Cargo);

    class DamageUnitVisitor : public UnitVisitor
    {
    public:
        int m_TotalDamage{};

        DECLARE_VISITOR_IMPL_FUNCTION(Artificer, Gun);
        DECLARE_VISITOR_IMPL_FUNCTION(Barbarian, Sword);
        DECLARE_VISITOR_IMPL_FUNCTION(Bard, Flute);
        DECLARE_VISITOR_IMPL_FUNCTION(Boat, Cargo);
    };

    std::vector<Unit*> g_Units;

    static void VisitorClasses04(benchmark::State& state)
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

    BENCHMARK(VisitorClasses04);
}

DEFINE_INIT_TEST_CASE_04_CLASSES(Visitor);