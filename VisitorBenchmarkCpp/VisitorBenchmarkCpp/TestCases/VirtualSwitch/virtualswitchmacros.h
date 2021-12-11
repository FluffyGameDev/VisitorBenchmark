#pragma once

#define DECLARE_VIRTUAL_SWITCH_BASE_UNIT() class Unit\
{\
public:\
    virtual ~Unit() = default;\
    virtual UnitType GetUnitType() const = 0;\
}

#define DECLARE_VIRTUAL_SWITCH_CHILD_UNIT(Name, Weapon) class Name##Unit : public Unit\
{\
public:\
    UnitType GetUnitType() const override { return UnitType::Name; }\
    int Weapon##Damage = 1;\
}

#define VIRTUAL_SWITCH_CASE(Name, Weapon) case UnitType::Name: { totalDamage += reinterpret_cast<const Name##Unit*>(unit)->Weapon##Damage; break; };