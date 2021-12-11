#pragma once

#define DECLARE_VIRTUAL_CALL_BASE_UNIT() class Unit\
{\
public:\
    virtual ~Unit() = default;\
    virtual int ComputeDamage() const = 0;\
}

#define DECLARE_VIRTUAL_CALL_CHILD_UNIT(Name, Weapon) class Name##Unit : public Unit\
{\
public:\
    int ComputeDamage() const override { return Weapon##Damage; }\
    int Weapon##Damage = 1;\
}