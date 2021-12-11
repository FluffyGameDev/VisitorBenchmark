#pragma once

#define DECLARE_VISITOR_BASE_UNIT() class Unit\
{\
public:\
    virtual ~Unit() = default;\
    virtual void Accept(UnitVisitor& visitor) const = 0;\
}

#define DECLARE_VISITOR_CHILD_UNIT(Name, Weapon) class Name##Unit : public Unit\
{\
public:\
    void Accept(UnitVisitor& visitor) const override { visitor.Visit##Name(*this); }\
    int Weapon##Damage = 1;\
}

#define FORWARD_DECLARE_VISITOR_CHILD_UNIT(Name) class Name##Unit;
#define DECLARE_VISITOR_VIRTUAL_FUNCTION(Name) virtual void Visit##Name(const Name##Unit& unit) = 0;
#define DECLARE_VISITOR_IMPL_FUNCTION(Name, Weapon) void Visit##Name(const Name##Unit& unit) override { m_TotalDamage += unit.Weapon##Damage; }