#pragma once

#define DECLARE_IF_ELSE_IF_BASE_UNIT() class Unit\
{\
public:\
    virtual ~Unit() = default;\
}

#define DECLARE_IF_ELSE_IF_CHILD_UNIT(Name, Weapon) class Name##Unit : public Unit\
{\
public:\
    int Weapon##Damage = 1;\
}

#define IF_ELSE_IF_COMPUTE_UNIT_DAMAGE(Name, Weapon) if (const Name##Unit* specificUnit = dynamic_cast<const Name##Unit*>(unit))\
{\
    totalDamage += specificUnit->Weapon##Damage;\
}