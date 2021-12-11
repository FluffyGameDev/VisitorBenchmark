#include "testvisitor.h"

#include "../globalmacros.h"
#include "visitormacros.h"
#include <benchmark/benchmark.h>

namespace TestCase::Visitor::Classes16
{
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Artificer);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Barbarian);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Bard);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Boat);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Cleric);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Dancer);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Druid);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Fighter);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Monk);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Ninja);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Paladin);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Ranger);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Rogue);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Sorcerer);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Warlock);
    FORWARD_DECLARE_VISITOR_CHILD_UNIT(Wizard);

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
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Monk);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Ninja);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Paladin);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Ranger);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Rogue);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Sorcerer);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Warlock);
        DECLARE_VISITOR_VIRTUAL_FUNCTION(Wizard);
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
    DECLARE_VISITOR_CHILD_UNIT(Monk, Fist);
    DECLARE_VISITOR_CHILD_UNIT(Ninja, Kunai);
    DECLARE_VISITOR_CHILD_UNIT(Paladin, Faith);
    DECLARE_VISITOR_CHILD_UNIT(Ranger, Bow);
    DECLARE_VISITOR_CHILD_UNIT(Rogue, Dagger);
    DECLARE_VISITOR_CHILD_UNIT(Sorcerer, Book);
    DECLARE_VISITOR_CHILD_UNIT(Warlock, Patron);
    DECLARE_VISITOR_CHILD_UNIT(Wizard, Wand);

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
        DECLARE_VISITOR_IMPL_FUNCTION(Monk, Fist);
        DECLARE_VISITOR_IMPL_FUNCTION(Ninja, Kunai);
        DECLARE_VISITOR_IMPL_FUNCTION(Paladin, Faith);
        DECLARE_VISITOR_IMPL_FUNCTION(Ranger, Bow);
        DECLARE_VISITOR_IMPL_FUNCTION(Rogue, Dagger);
        DECLARE_VISITOR_IMPL_FUNCTION(Sorcerer, Book);
        DECLARE_VISITOR_IMPL_FUNCTION(Warlock, Patron);
        DECLARE_VISITOR_IMPL_FUNCTION(Wizard, Wand);
    };

    std::vector<Unit*> g_Units;

    static void VisitorClasses16(benchmark::State& state)
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

    BENCHMARK(VisitorClasses16);
}

DEFINE_INIT_TEST_CASE_16_CLASSES(Visitor);