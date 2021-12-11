#pragma once

#define DECLARE_NO_VIRTUAL_SWITCH_BASE_UNIT() class Unit\
{\
public:\
    Unit(UnitType unitType): m_UnitType{ unitType } {}\
    virtual ~Unit() = default;\
    UnitType GetUnitType() const { return m_UnitType; }\
private:\
    UnitType m_UnitType{};\
}

#define DECLARE_NO_VIRTUAL_SWITCH_CHILD_UNIT(Name, Weapon) class Name##Unit : public Unit\
{\
public:\
    Name##Unit(): Unit{ UnitType::Name } {}\
    int Weapon##Damage = 1;\
}

#define NO_VIRTUAL_SWITCH_CASE(Name, Weapon) case UnitType::Name: { totalDamage += reinterpret_cast<const Name##Unit*>(unit)->Weapon##Damage; break; };