﻿module Ploeh.Numsense.DanishExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                              "nul",          0)>]
[<InlineData(                                             " nul",          0)>]
[<InlineData(                                             "nul ",          0)>]
[<InlineData(                                          "  nul  ",          0)>]
[<InlineData(                                              "Nul",          0)>]
[<InlineData(                                              "NUL",          0)>]
[<InlineData(                                            "nUl\t",          0)>]
[<InlineData(                                               "et",          1)>]
[<InlineData(                                               "en",          1)>]
[<InlineData(                                               "ET",          1)>]
[<InlineData(                                               "to",          2)>]
[<InlineData(                                              " to",          2)>]
[<InlineData(                                              "tre",          3)>]
[<InlineData(                                            "tre  ",          3)>]
[<InlineData(                                             "fire",          4)>]
[<InlineData(                                          "  fire ",          4)>]
[<InlineData(                                              "fem",          5)>]
[<InlineData(                                              "FeM",          5)>]
[<InlineData(                                             "seks",          6)>]
[<InlineData(                                         "  SEKS  ",          6)>]
[<InlineData(                                              "syv",          7)>]
[<InlineData(                                          "    sYv",          7)>]
[<InlineData(                                             "otte",          8)>]
[<InlineData(                                             "oTTE",          8)>]
[<InlineData(                                               "ni",          9)>]
[<InlineData(                                             "Ni  ",          9)>]
[<InlineData(                                               "ti",         10)>]
[<InlineData(                                           "elleve",         11)>]
[<InlineData(                                             "tolv",         12)>]
[<InlineData(                                          "tretten",         13)>]
[<InlineData(                                          "fjorten",         14)>]
[<InlineData(                                           "femten",         15)>]
[<InlineData(                                          "seksten",         16)>]
[<InlineData(                                           "sytten",         17)>]
[<InlineData(                                            "atten",         18)>]
[<InlineData(                                           "nitten",         19)>]
[<InlineData(                                             "tyve",         20)>]
[<InlineData(                                         "enogtyve",         21)>]
[<InlineData(                                          "tredive",         30)>]
[<InlineData(                                    "fireogtredive",         34)>]
[<InlineData(                                            "fyrre",         40)>]
[<InlineData(                                      "fireogfyrre",         44)>]
[<InlineData(                                        "halvtreds",         50)>]
[<InlineData(                                   "syvoghalvtreds",         57)>]
[<InlineData(                                             "tres",         60)>]
[<InlineData(                                        "femogtres",         65)>]
[<InlineData(                                       "halvfjerds",         70)>]
[<InlineData(                                   "nioghalvfjerds",         79)>]
[<InlineData(                                             "firs",         80)>]
[<InlineData(                                       "seksogfirs",         86)>]
[<InlineData(                                         "halvfems",         90)>]
[<InlineData(                                    "treoghalvfems",         93)>]
[<InlineData(                                         "hundrede",        100)>]
[<InlineData(                                       "ethundrede",        100)>]
[<InlineData(                                       "hundredeet",        101)>]
[<InlineData(                                     "hundredeoget",        101)>]
[<InlineData(                                   "hundrede-og-et",        101)>]
[<InlineData(                                     "ethundredeet",        101)>]
[<InlineData(                                   "ethundredeoget",        101)>]
[<InlineData(                                "et-hundrede-og-et",        101)>]
[<InlineData(                                       "tohundrede",        200)>]
[<InlineData(                           "tohundredesyvogtredive",        237)>]
[<InlineData(                       "trehundredefemoghalvfjerds",        375)>]
[<InlineData(                             "firehundredehalvfems",        490)>]
[<InlineData(                             "femhundredetreogtres",        563)>]
[<InlineData(                                "sekshundredeatten",        618)>]
[<InlineData(                       "syvhundredesyvoghalvfjerds",        777)>]
[<InlineData(                                "ottehundredeogfem",        805)>]
[<InlineData(                               "ottehundredeogseks",        806)>]
[<InlineData(                             "otte-hundrede-og-syv",        807)>]
[<InlineData(                          "nihundredenioghalvtreds",        959)>]
[<InlineData(                                           "tusind",       1000)>]
[<InlineData(                                         "ettusind",       1000)>]
[<InlineData(                                       "tusindogen",       1001)>]
[<InlineData(                                     "ettusindogto",       1002)>]
[<InlineData(                             "ettusindogfireogtres",       1064)>]
[<InlineData(                                         "totusind",       2000)>]
[<InlineData(                  "ottetusindsyvhundredeogenogtyve",       8721)>]
[<InlineData(                "ni-tusind-et-hundrede-tre-og-tyve",       9123)>]
[<InlineData(                                         "titusind",      10000)>]
[<InlineData(                             "titusindethundredeet",      10101)>]
[<InlineData(                      "ti-tusind-et-hundrede-og-to",      10102)>]
[<InlineData(             "treogtyvetusindfemhundredefireogtres",      23564)>]
[<InlineData(                                   "firstusindogti",      80010)>]
[<InlineData(                                   "hundredetusind",     100000)>]
[<InlineData(                                 "ethundredetusind",     100000)>]
[<InlineData(                             "ethundredetusindoget",     100001)>]
[<InlineData(      "trehundredenittentusindtrehundredeniogfyrre",     319349)>]
[<InlineData(                                        "enmillion",    1000000)>]
[<InlineData(                                      "enmillionen",    1000001)>]
[<InlineData(                                    "tomillionerti",    2000010)>]
[<InlineData(                     "seksmillionerogtredivetusind",    6030000)>]
[<InlineData(    "nimillionertohundredeettusindsekshundredefirs",    9201680)>]
[<InlineData(                                      "timillioner",   10000000)>]
[<InlineData(                                  "timillionerogni",   10000009)>]
[<InlineData(                               "enogtyve millioner",   21000000)>]
[<InlineData("syvogfyrremillionersekshundredeenogtrestusindtres",   47661060)>]
[<InlineData(                               "hundrede millioner",  100000000)>]
[<InlineData(                              "ethundredemillioner",  100000000)>]
[<InlineData(                           "tohundredefemmillioner",  205000000)>]
[<InlineData(                    "tre-hundrede-og-syv-millioner",  307000000)>]
[<InlineData("firehundredeenogtresmillionertrestusindtohundrede",  461060200)>]
[<InlineData(                                       "enmilliard", 1000000000)>]
[<InlineData(                                    "to milliarder", 2000000000)>]
[<InlineData("tomilliarderniogtyvemillionertohundredetrestusind", 2029260000)>]
[<InlineData(
    "tomilliarderethundredesyvogfyrremillionerfirehundredetreogfirstusindsekshundredesyvogfyrre",
    System.Int32.MaxValue)>]
let ``tryOfDanish returns correct result`` (danish : string, expected : int) =
    let actual = Numeral.tryOfDanish danish
    Some expected =! actual

[<Theory>]
[<InlineData(         0, "nul")>]
[<InlineData(         1, "et")>]
[<InlineData(         2, "to")>]
[<InlineData(         3, "tre")>]
[<InlineData(         4, "fire")>]
[<InlineData(         5, "fem")>]
[<InlineData(         6, "seks")>]
[<InlineData(         7, "syv")>]
[<InlineData(         8, "otte")>]
[<InlineData(         9, "ni")>]
[<InlineData(        10, "ti")>]
[<InlineData(        11, "elleve")>]
[<InlineData(        12, "tolv")>]
[<InlineData(        13, "tretten")>]
[<InlineData(        14, "fjorten")>]
[<InlineData(        15, "femten")>]
[<InlineData(        16, "seksten")>]
[<InlineData(        17, "sytten")>]
[<InlineData(        18, "atten")>]
[<InlineData(        19, "nitten")>]
[<InlineData(        20, "tyve")>]
[<InlineData(        21, "en-og-tyve")>]
[<InlineData(        30, "tredive")>]
[<InlineData(        34, "fire-og-tredive")>]
[<InlineData(        40, "fyrre")>]
[<InlineData(        42, "to-og-fyrre")>]
[<InlineData(        50, "halvtreds")>]
[<InlineData(        58, "otte-og-halvtreds")>]
[<InlineData(        60, "tres")>]
[<InlineData(        65, "fem-og-tres")>]
[<InlineData(        70, "halvfjerds")>]
[<InlineData(        79, "ni-og-halvfjerds")>]
[<InlineData(        80, "firs")>]
[<InlineData(        86, "seks-og-firs")>]
[<InlineData(        90, "halvfems")>]
[<InlineData(        93, "tre-og-halvfems")>]
let ``toDanish returns correct result`` (i : int, expected : string) =
    let actual = Numeral.toDanish i
    expected =! actual