// Lucene version compatibility level 4.8.1
/*

Copyright (c) 2001, Dr Martin Porter
Copyright (c) 2002, Richard Boulton
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

    * Redistributions of source code must retain the above copyright notice,
    * this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
    * notice, this list of conditions and the following disclaimer in the
    * documentation and/or other materials provided with the distribution.
    * Neither the name of the copyright holders nor the names of its contributors
    * may be used to endorse or promote products derived from this software
    * without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

 */

namespace Lucene.Net.Tartarus.Snowball.Ext
{
    /// <summary>
    /// This class was automatically generated by a Snowball to Java compiler
    /// It implements the stemming algorithm defined by a snowball script.
    /// </summary>
    public class German2Stemmer : SnowballProgram
    {
        private readonly static German2Stemmer methodObject = new German2Stemmer();

        private readonly static Among[] a_0 = {
                    new Among ( "", -1, 6, "", methodObject ),
                    new Among ( "ae", 0, 2, "", methodObject ),
                    new Among ( "oe", 0, 3, "", methodObject ),
                    new Among ( "qu", 0, 5, "", methodObject ),
                    new Among ( "ue", 0, 4, "", methodObject ),
                    new Among ( "\u00DF", 0, 1, "", methodObject )
                };

        private readonly static Among[] a_1 = {
                    new Among ( "", -1, 6, "", methodObject ),
                    new Among ( "U", 0, 2, "", methodObject ),
                    new Among ( "Y", 0, 1, "", methodObject ),
                    new Among ( "\u00E4", 0, 3, "", methodObject ),
                    new Among ( "\u00F6", 0, 4, "", methodObject ),
                    new Among ( "\u00FC", 0, 5, "", methodObject )
                };

        private readonly static Among[] a_2 = {
                    new Among ( "e", -1, 1, "", methodObject ),
                    new Among ( "em", -1, 1, "", methodObject ),
                    new Among ( "en", -1, 1, "", methodObject ),
                    new Among ( "ern", -1, 1, "", methodObject ),
                    new Among ( "er", -1, 1, "", methodObject ),
                    new Among ( "s", -1, 2, "", methodObject ),
                    new Among ( "es", 5, 1, "", methodObject )
                };

        private readonly static Among[] a_3 = {
                    new Among ( "en", -1, 1, "", methodObject ),
                    new Among ( "er", -1, 1, "", methodObject ),
                    new Among ( "st", -1, 2, "", methodObject ),
                    new Among ( "est", 2, 1, "", methodObject )
                };

        private readonly static Among[] a_4 = {
                    new Among ( "ig", -1, 1, "", methodObject ),
                    new Among ( "lich", -1, 1, "", methodObject )
                };

        private readonly static Among[] a_5 = {
                    new Among ( "end", -1, 1, "", methodObject ),
                    new Among ( "ig", -1, 2, "", methodObject ),
                    new Among ( "ung", -1, 1, "", methodObject ),
                    new Among ( "lich", -1, 3, "", methodObject ),
                    new Among ( "isch", -1, 2, "", methodObject ),
                    new Among ( "ik", -1, 2, "", methodObject ),
                    new Among ( "heit", -1, 3, "", methodObject ),
                    new Among ( "keit", -1, 4, "", methodObject )
                };

        private static readonly char[] g_v = { (char)17, (char)65, (char)16, (char)1, (char)0, (char)0, (char)0, (char)0, (char)0, (char)0, (char)0, (char)0, (char)0, (char)0, (char)0, (char)0, (char)8, (char)0, (char)32, (char)8 };

        private static readonly char[] g_s_ending = { (char)117, (char)30, (char)5 };

        private static readonly char[] g_st_ending = { (char)117, (char)30, (char)4 };

        private int I_x;
        private int I_p2;
        private int I_p1;

        private void copy_from(German2Stemmer other)
        {
            I_x = other.I_x;
            I_p2 = other.I_p2;
            I_p1 = other.I_p1;
            base.CopyFrom(other);
        }

        private bool r_prelude()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            int v_4;
            int v_5;
            // (, line 28
            // test, line 30
            v_1 = m_cursor;
            // repeat, line 30

            while (true)
            {
                v_2 = m_cursor;

                do
                {
                    // goto, line 30

                    while (true)
                    {
                        v_3 = m_cursor;

                        do
                        {
                            // (, line 30
                            if (!(InGrouping(g_v, 97, 252)))
                            {
                                goto lab3;
                            }
                            // [, line 31
                            m_bra = m_cursor;
                            // or, line 31

                            do
                            {
                                v_4 = m_cursor;

                                do
                                {
                                    // (, line 31
                                    // literal, line 31
                                    if (!(Eq_S(1, "u")))
                                    {
                                        goto lab5;
                                    }
                                    // ], line 31
                                    m_ket = m_cursor;
                                    if (!(InGrouping(g_v, 97, 252)))
                                    {
                                        goto lab5;
                                    }
                                    // <-, line 31
                                    SliceFrom("U");
                                    goto lab4;
                                } while (false);
                                lab5:
                                m_cursor = v_4;
                                // (, line 32
                                // literal, line 32
                                if (!(Eq_S(1, "y")))
                                {
                                    goto lab3;
                                }
                                // ], line 32
                                m_ket = m_cursor;
                                if (!(InGrouping(g_v, 97, 252)))
                                {
                                    goto lab3;
                                }
                                // <-, line 32
                                SliceFrom("Y");
                            } while (false);
                            lab4:
                            m_cursor = v_3;
                            goto golab2;
                        } while (false);
                        lab3:
                        m_cursor = v_3;
                        if (m_cursor >= m_limit)
                        {
                            goto lab1;
                        }
                        m_cursor++;
                    }
                    golab2:
                    // LUCENENET NOTE: continue label is not supported directly in .NET,
                    // so we just need to add another goto to get to the end of the outer loop.
                    // See: http://stackoverflow.com/a/359449/181087

                    // Original code:
                    //continue replab0;

                    goto end_of_outer_loop;

                } while (false);
                lab1:
                m_cursor = v_2;
                goto replab0;
                end_of_outer_loop: { }
            }
            replab0:
            m_cursor = v_1;
            // repeat, line 35

            while (true)
            {
                v_5 = m_cursor;

                do
                {
                    // (, line 35
                    // [, line 36
                    m_bra = m_cursor;
                    // substring, line 36
                    among_var = FindAmong(a_0, 6);
                    if (among_var == 0)
                    {
                        goto lab7;
                    }
                    // ], line 36
                    m_ket = m_cursor;
                    switch (among_var)
                    {
                        case 0:
                            goto lab7;
                        case 1:
                            // (, line 37
                            // <-, line 37
                            SliceFrom("ss");
                            break;
                        case 2:
                            // (, line 38
                            // <-, line 38
                            SliceFrom("\u00E4");
                            break;
                        case 3:
                            // (, line 39
                            // <-, line 39
                            SliceFrom("\u00F6");
                            break;
                        case 4:
                            // (, line 40
                            // <-, line 40
                            SliceFrom("\u00FC");
                            break;
                        case 5:
                            // (, line 41
                            // hop, line 41
                            {
                                int c = m_cursor + 2;
                                if (0 > c || c > m_limit)
                                {
                                    goto lab7;
                                }
                                m_cursor = c;
                            }
                            break;
                        case 6:
                            // (, line 42
                            // next, line 42
                            if (m_cursor >= m_limit)
                            {
                                goto lab7;
                            }
                            m_cursor++;
                            break;
                    }
                    // LUCENENET NOTE: continue label is not supported directly in .NET,
                    // so we just need to add another goto to get to the end of the outer loop.
                    // See: http://stackoverflow.com/a/359449/181087

                    // Original code:
                    //continue replab6;

                    goto end_of_outer_loop_2;

                } while (false);
                lab7:
                m_cursor = v_5;
                goto replab6;
                end_of_outer_loop_2: { }
            }
            replab6:
            return true;
        }

        private bool r_mark_regions()
        {
            int v_1;
            // (, line 48
            I_p1 = m_limit;
            I_p2 = m_limit;
            // test, line 53
            v_1 = m_cursor;
            // (, line 53
            // hop, line 53
            {
                int c = m_cursor + 3;
                if (0 > c || c > m_limit)
                {
                    return false;
                }
                m_cursor = c;
            }
            // setmark x, line 53
            I_x = m_cursor;
            m_cursor = v_1;
            // gopast, line 55

            while (true)
            {

                do
                {
                    if (!(InGrouping(g_v, 97, 252)))
                    {
                        goto lab1;
                    }
                    goto golab0;
                } while (false);
                lab1:
                if (m_cursor >= m_limit)
                {
                    return false;
                }
                m_cursor++;
            }
            golab0:
            // gopast, line 55

            while (true)
            {

                do
                {
                    if (!(OutGrouping(g_v, 97, 252)))
                    {
                        goto lab3;
                    }
                    goto golab2;
                } while (false);
                lab3:
                if (m_cursor >= m_limit)
                {
                    return false;
                }
                m_cursor++;
            }
            golab2:
            // setmark p1, line 55
            I_p1 = m_cursor;
            // try, line 56

            do
            {
                // (, line 56
                if (!(I_p1 < I_x))
                {
                    goto lab4;
                }
                I_p1 = I_x;
            } while (false);
            lab4:
            // gopast, line 57

            while (true)
            {

                do
                {
                    if (!(InGrouping(g_v, 97, 252)))
                    {
                        goto lab6;
                    }
                    goto golab5;
                } while (false);
                lab6:
                if (m_cursor >= m_limit)
                {
                    return false;
                }
                m_cursor++;
            }
            golab5:
            // gopast, line 57

            while (true)
            {

                do
                {
                    if (!(OutGrouping(g_v, 97, 252)))
                    {
                        goto lab8;
                    }
                    goto golab7;
                } while (false);
                lab8:
                if (m_cursor >= m_limit)
                {
                    return false;
                }
                m_cursor++;
            }
            golab7:
            // setmark p2, line 57
            I_p2 = m_cursor;
            return true;
        }

        private bool r_postlude()
        {
            int among_var;
            int v_1;
            // repeat, line 61

            while (true)
            {
                v_1 = m_cursor;

                do
                {
                    // (, line 61
                    // [, line 63
                    m_bra = m_cursor;
                    // substring, line 63
                    among_var = FindAmong(a_1, 6);
                    if (among_var == 0)
                    {
                        goto lab1;
                    }
                    // ], line 63
                    m_ket = m_cursor;
                    switch (among_var)
                    {
                        case 0:
                            goto lab1;
                        case 1:
                            // (, line 64
                            // <-, line 64
                            SliceFrom("y");
                            break;
                        case 2:
                            // (, line 65
                            // <-, line 65
                            SliceFrom("u");
                            break;
                        case 3:
                            // (, line 66
                            // <-, line 66
                            SliceFrom("a");
                            break;
                        case 4:
                            // (, line 67
                            // <-, line 67
                            SliceFrom("o");
                            break;
                        case 5:
                            // (, line 68
                            // <-, line 68
                            SliceFrom("u");
                            break;
                        case 6:
                            // (, line 69
                            // next, line 69
                            if (m_cursor >= m_limit)
                            {
                                goto lab1;
                            }
                            m_cursor++;
                            break;
                    }
                    // LUCENENET NOTE: continue label is not supported directly in .NET,
                    // so we just need to add another goto to get to the end of the outer loop.
                    // See: http://stackoverflow.com/a/359449/181087

                    // Original code:
                    //continue replab0;

                    goto end_of_outer_loop;

                } while (false);
                lab1:
                m_cursor = v_1;
                goto replab0;
                end_of_outer_loop: { }
            }
            replab0:
            return true;
        }

        private bool r_R1()
        {
            if (!(I_p1 <= m_cursor))
            {
                return false;
            }
            return true;
        }

        private bool r_R2()
        {
            if (!(I_p2 <= m_cursor))
            {
                return false;
            }
            return true;
        }

        private bool r_standard_suffix()
        {
            int among_var;
            int v_1;
            int v_2;
            int v_3;
            int v_4;
            int v_5;
            int v_6;
            int v_7;
            int v_8;
            int v_9;
            // (, line 79
            // do, line 80
            v_1 = m_limit - m_cursor;

            do
            {
                // (, line 80
                // [, line 81
                m_ket = m_cursor;
                // substring, line 81
                among_var = FindAmongB(a_2, 7);
                if (among_var == 0)
                {
                    goto lab0;
                }
                // ], line 81
                m_bra = m_cursor;
                // call R1, line 81
                if (!r_R1())
                {
                    goto lab0;
                }
                switch (among_var)
                {
                    case 0:
                        goto lab0;
                    case 1:
                        // (, line 83
                        // delete, line 83
                        SliceDel();
                        break;
                    case 2:
                        // (, line 86
                        if (!(InGroupingB(g_s_ending, 98, 116)))
                        {
                            goto lab0;
                        }
                        // delete, line 86
                        SliceDel();
                        break;
                }
            } while (false);
            lab0:
            m_cursor = m_limit - v_1;
            // do, line 90
            v_2 = m_limit - m_cursor;

            do
            {
                // (, line 90
                // [, line 91
                m_ket = m_cursor;
                // substring, line 91
                among_var = FindAmongB(a_3, 4);
                if (among_var == 0)
                {
                    goto lab1;
                }
                // ], line 91
                m_bra = m_cursor;
                // call R1, line 91
                if (!r_R1())
                {
                    goto lab1;
                }
                switch (among_var)
                {
                    case 0:
                        goto lab1;
                    case 1:
                        // (, line 93
                        // delete, line 93
                        SliceDel();
                        break;
                    case 2:
                        // (, line 96
                        if (!(InGroupingB(g_st_ending, 98, 116)))
                        {
                            goto lab1;
                        }
                        // hop, line 96
                        {
                            int c = m_cursor - 3;
                            if (m_limit_backward > c || c > m_limit)
                            {
                                goto lab1;
                            }
                            m_cursor = c;
                        }
                        // delete, line 96
                        SliceDel();
                        break;
                }
            } while (false);
            lab1:
            m_cursor = m_limit - v_2;
            // do, line 100
            v_3 = m_limit - m_cursor;

            do
            {
                // (, line 100
                // [, line 101
                m_ket = m_cursor;
                // substring, line 101
                among_var = FindAmongB(a_5, 8);
                if (among_var == 0)
                {
                    goto lab2;
                }
                // ], line 101
                m_bra = m_cursor;
                // call R2, line 101
                if (!r_R2())
                {
                    goto lab2;
                }
                switch (among_var)
                {
                    case 0:
                        goto lab2;
                    case 1:
                        // (, line 103
                        // delete, line 103
                        SliceDel();
                        // try, line 104
                        v_4 = m_limit - m_cursor;

                        do
                        {
                            // (, line 104
                            // [, line 104
                            m_ket = m_cursor;
                            // literal, line 104
                            if (!(Eq_S_B(2, "ig")))
                            {
                                m_cursor = m_limit - v_4;
                                goto lab3;
                            }
                            // ], line 104
                            m_bra = m_cursor;
                            // not, line 104
                            {
                                v_5 = m_limit - m_cursor;

                                do
                                {
                                    // literal, line 104
                                    if (!(Eq_S_B(1, "e")))
                                    {
                                        goto lab4;
                                    }
                                    m_cursor = m_limit - v_4;
                                    goto lab3;
                                } while (false);
                                lab4:
                                m_cursor = m_limit - v_5;
                            }
                            // call R2, line 104
                            if (!r_R2())
                            {
                                m_cursor = m_limit - v_4;
                                goto lab3;
                            }
                            // delete, line 104
                            SliceDel();
                        } while (false);
                        lab3:
                        break;
                    case 2:
                        // (, line 107
                        // not, line 107
                        {
                            v_6 = m_limit - m_cursor;

                            do
                            {
                                // literal, line 107
                                if (!(Eq_S_B(1, "e")))
                                {
                                    goto lab5;
                                }
                                goto lab2;
                            } while (false);
                            lab5:
                            m_cursor = m_limit - v_6;
                        }
                        // delete, line 107
                        SliceDel();
                        break;
                    case 3:
                        // (, line 110
                        // delete, line 110
                        SliceDel();
                        // try, line 111
                        v_7 = m_limit - m_cursor;

                        do
                        {
                            // (, line 111
                            // [, line 112
                            m_ket = m_cursor;
                            // or, line 112

                            do
                            {
                                v_8 = m_limit - m_cursor;

                                do
                                {
                                    // literal, line 112
                                    if (!(Eq_S_B(2, "er")))
                                    {
                                        goto lab8;
                                    }
                                    goto lab7;
                                } while (false);
                                lab8:
                                m_cursor = m_limit - v_8;
                                // literal, line 112
                                if (!(Eq_S_B(2, "en")))
                                {
                                    m_cursor = m_limit - v_7;
                                    goto lab6;
                                }
                            } while (false);
                            lab7:
                            // ], line 112
                            m_bra = m_cursor;
                            // call R1, line 112
                            if (!r_R1())
                            {
                                m_cursor = m_limit - v_7;
                                goto lab6;
                            }
                            // delete, line 112
                            SliceDel();
                        } while (false);
                        lab6:
                        break;
                    case 4:
                        // (, line 116
                        // delete, line 116
                        SliceDel();
                        // try, line 117
                        v_9 = m_limit - m_cursor;

                        do
                        {
                            // (, line 117
                            // [, line 118
                            m_ket = m_cursor;
                            // substring, line 118
                            among_var = FindAmongB(a_4, 2);
                            if (among_var == 0)
                            {
                                m_cursor = m_limit - v_9;
                                goto lab9;
                            }
                            // ], line 118
                            m_bra = m_cursor;
                            // call R2, line 118
                            if (!r_R2())
                            {
                                m_cursor = m_limit - v_9;
                                goto lab9;
                            }
                            switch (among_var)
                            {
                                case 0:
                                    m_cursor = m_limit - v_9;
                                    goto lab9;
                                case 1:
                                    // (, line 120
                                    // delete, line 120
                                    SliceDel();
                                    break;
                            }
                        } while (false);
                        lab9:
                        break;
                }
            } while (false);
            lab2:
            m_cursor = m_limit - v_3;
            return true;
        }


        public override bool Stem()
        {
            int v_1;
            int v_2;
            int v_3;
            int v_4;
            // (, line 130
            // do, line 131
            v_1 = m_cursor;

            do
            {
                // call prelude, line 131
                if (!r_prelude())
                {
                    goto lab0;
                }
            } while (false);
            lab0:
            m_cursor = v_1;
            // do, line 132
            v_2 = m_cursor;
            do
            {
                // call mark_regions, line 132
                if (!r_mark_regions())
                {
                    goto lab1;
                }
            } while (false);
            lab1:
            m_cursor = v_2;
            // backwards, line 133
            m_limit_backward = m_cursor; m_cursor = m_limit;
            // do, line 134
            v_3 = m_limit - m_cursor;
            do
            {
                // call standard_suffix, line 134
                if (!r_standard_suffix())
                {
                    goto lab2;
                }
            } while (false);
            lab2:
            m_cursor = m_limit - v_3;
            m_cursor = m_limit_backward;                    // do, line 135
            v_4 = m_cursor;
            do
            {
                // call postlude, line 135
                if (!r_postlude())
                {
                    goto lab3;
                }
            } while (false);
            lab3:
            m_cursor = v_4;
            return true;
        }

        public override bool Equals(object o)
        {
            return o is German2Stemmer;
        }

        public override int GetHashCode()
        {
            return this.GetType().FullName.GetHashCode();
        }
    }
}