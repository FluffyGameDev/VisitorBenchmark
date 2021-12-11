
#define INIT_TEST_CASE_04_CLASSES() for (int i = 0; i < 1024; ++i)\
{\
    switch (i % 4)\
    {\
        case 0:  { Classes04::g_Units.push_back(new Classes04::ArtificerUnit); break; }\
        case 1:  { Classes04::g_Units.push_back(new Classes04::BarbarianUnit); break; }\
        case 2:  { Classes04::g_Units.push_back(new Classes04::BardUnit); break; }\
        case 3:  { Classes04::g_Units.push_back(new Classes04::BoatUnit); break; }\
    }\
}

#define INIT_TEST_CASE_08_CLASSES() for (int i = 0; i < 1024; ++i)\
{\
    switch (i % 8)\
    {\
        case 0:  { Classes08::g_Units.push_back(new Classes08::ArtificerUnit); break; }\
        case 1:  { Classes08::g_Units.push_back(new Classes08::BarbarianUnit); break; }\
        case 2:  { Classes08::g_Units.push_back(new Classes08::BardUnit); break; }\
        case 3:  { Classes08::g_Units.push_back(new Classes08::BoatUnit); break; }\
        case 4:  { Classes08::g_Units.push_back(new Classes08::ClericUnit); break; }\
        case 5:  { Classes08::g_Units.push_back(new Classes08::DancerUnit); break; }\
        case 6:  { Classes08::g_Units.push_back(new Classes08::DruidUnit); break; }\
        case 7:  { Classes08::g_Units.push_back(new Classes08::FighterUnit); break; }\
    }\
}

#define INIT_TEST_CASE_16_CLASSES() for (int i = 0; i < 1024; ++i)\
{\
    switch (i % 16)\
    {\
        case 0:  { Classes16::g_Units.push_back(new Classes16::ArtificerUnit); break; }\
        case 1:  { Classes16::g_Units.push_back(new Classes16::BarbarianUnit); break; }\
        case 2:  { Classes16::g_Units.push_back(new Classes16::BardUnit); break; }\
        case 3:  { Classes16::g_Units.push_back(new Classes16::BoatUnit); break; }\
        case 4:  { Classes16::g_Units.push_back(new Classes16::ClericUnit); break; }\
        case 5:  { Classes16::g_Units.push_back(new Classes16::DancerUnit); break; }\
        case 6:  { Classes16::g_Units.push_back(new Classes16::DruidUnit); break; }\
        case 7:  { Classes16::g_Units.push_back(new Classes16::FighterUnit); break; }\
        case 8:  { Classes16::g_Units.push_back(new Classes16::MonkUnit); break; }\
        case 9:  { Classes16::g_Units.push_back(new Classes16::NinjaUnit); break; }\
        case 10: { Classes16::g_Units.push_back(new Classes16::PaladinUnit); break; }\
        case 11: { Classes16::g_Units.push_back(new Classes16::RangerUnit); break; }\
        case 12: { Classes16::g_Units.push_back(new Classes16::RogueUnit); break; }\
        case 13: { Classes16::g_Units.push_back(new Classes16::SorcererUnit); break; }\
        case 14: { Classes16::g_Units.push_back(new Classes16::WarlockUnit); break; }\
        case 15: { Classes16::g_Units.push_back(new Classes16::WizardUnit); break; }\
    }\
}

#define DEFINE_INIT_TEST_CASE_04_CLASSES(TestName) namespace TestCase::TestName\
{\
    void InitTest04Classes()\
    {\
        INIT_TEST_CASE_04_CLASSES();\
    }\
}

#define DEFINE_INIT_TEST_CASE_08_CLASSES(TestName) namespace TestCase::TestName\
{\
    void InitTest08Classes()\
    {\
        INIT_TEST_CASE_08_CLASSES();\
    }\
}

#define DEFINE_INIT_TEST_CASE_16_CLASSES(TestName) namespace TestCase::TestName\
{\
    void InitTest16Classes()\
    {\
        INIT_TEST_CASE_16_CLASSES();\
    }\
}