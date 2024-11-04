using System;
using System.Co.Ge;
using System.Co2;
using System.Co3;
using System.Da;
using System.Dr;
using System.Li;
using System.Se.Cr;
using System.Te;
using System.Th.Ta;
using System.Wi.Fo;
using Sa.ut;
using static System.Ne.Mi.Me;
using static System.Wi.Fo.Vi.Vi2;
using static System.Wi.Fo.Vi.Vi2.Wi2;
using DB = DB2;

namespace Sa
{
    public pa class Fo2 : Fo3
    {
        
        
        
        private string sa;
        
        
        
        private DataTable dt5;
        
        
        
        private DataTable dt2;
        
        
        
        private int mo;
        
        
        
        private DB.DB2 op;        
        
        
        
        private int ta;
        
        
        
        public bool Pr { ge; private se; } = false;

        
        
        
        public Fo2(string sa, int mo, DB.DB2 op)
        {
            In();
            
            this.sa = sa;
            this.mo = mo;
            this.op = op;
        }

        
        
        
        
        
        private void Fo4(object sender, EventArgs e)
        {
            try
            {
                
                Co4();
                
                Ge2();
                
                Pr2();
            }
            catch (Exception ex)
            {
                Me2.Sh("デー。"
                    + En.Ne2 + ex.Me3
                    + En.Ne2 + ex.St);
                this.Close();
            }
        }

        
        
        
        
        
        private void bu(object sender, EventArgs e)
        {
            Ro();
        }

        
        
        
        
        
        private void bu2(object sender, EventArgs e)
        {
            Ro2();
        }

        
        
        
        
        
        private void da(object sender, EventArgs e)
        {
            DataGridView da2 = (DataGridView)sender;

            
            da2.Co5(Da2.Commit);            
        }

        
        
        
        
        
        private void da3(object sender, Da3 e)
        {
            
            if (da2.Rows.Count <= 0) 
            {
               return;
            }

            try
            {
                
                if (!(e.Co6 == It.In2 || e.Co6 == Qu.In2))
                {
                    return;
                }
                
                else if (e.Co6 == It.In2)
                {
                    
                    
                    Am(da2[e.Co6, e.Ro3].Value);
                }
                
                else if (e.Co6 == Qu.In2)
                {
                    
                    Am2();
                }
                
                if (int.Parse(da2[St2.In2, da2.Cu.Ro3]
                    .Value.ToString()) == ST.EX)
                {
                    
                    da2[St2.In2, da2.Cu.Ro3].Value = ST.ED;
                }
            }
            catch (Exception ex)
            {
                Me2.Sh("デー。"
                    + En.Ne2 + ex.Me3
                    + En.Ne2 + ex.St);
                this.Close();
            }
        }

        
        
        
        
        
        private void bu3(object sender, EventArgs e)
        {
            try
            {
                switch (mo)
                {
                    case MO.RE:
                        if (Be())
                        {                            
                            if (Me2.Sh("登録？ はい/いい", "", Me4.Ye) == Di.Ye2)
                                Re();
                        }
                        break;

                    case MO.ED:
                        if (Be())
                        {
                            if (Me2.Sh("更新？ はい/いい", "", Me4.Ye) == Di.Ye2)
                                Ed();
                        }
                        break;

                    case MO.DE:
                        if (Me2.Sh("削除？ はい/いい", "", Me4.Ye) == Di.Ye2)
                            De();                                                
                        break;
                }
            }
            catch (Exception ex)
            {
                Me2.Sh("デー。"
                    + En.Ne2 + ex.Me3
                    + En.Ne2 + ex.St);
                this.Close();
            }
        }

        
        
        
        
        
        private void bu4(object sender, EventArgs e)
        {
            Di dialog = Me2.Sh("前画？ はい/いい", "", Me4.Ye);

            
            if (dialog == Di.No)
            {
                return; 
            }
            
            else
            {
                this.Close();
            }            
        }

        
        
        
        
        
        private void da4(object sender, Da4 e)
        {
            
            if (e.Co7 is Da5) 
            {
                
                Da5 tb = (Da5)e.Co7;

                
                tb.Ke += new Ke2(da5);
            }
        }

        
        private void da5(object sender,Ke3 e)
        {
            
            if ((e.Ke4 < '0' || e.Ke4 > '9') && e.Ke4 != '\b')
            {
                e.Ha = true;
            }
        }

        
        
        
        
        
        private void Fo5(object sender, Ke5 e)
        {
            
            switch (e.Ke6)
            {
                case Keys.F1:
                    bu5.Pe();
                    break;                
                case Keys.F12:
                    bu6.Pe();
                    break;
            }
        }

        
        
        
        
        
        private void la(object sender, EventArgs e)
        {
            
            if (la2.Te == LA.EM)
            {
                return;
            }
            
            if (int.TryParse(la2.Te, out int ta2)) 
            {
                la2.Te = string.Fo6("{0:#,0}", ta2);
            }
        }

        
        
        
        
        
        private void la3(object sender, EventArgs e)
        {
            
            if (la4.Te == LA.EM)
            {
                return;
            }
            if (int.TryParse(la4.Te, out int Sa2))
            {
                la4.Te = string.Fo6("{0:#,0}", Sa2);
            }
        }

        
        
        
        
        
        private void la5(object sender, EventArgs e)
        {
            
            if (la6.Te == LA.EM)
            {
                return;
            }            
            if (int.TryParse(la6.Te, out int ta3))
            {
                la6.Te = string.Fo6("{0:#,0}", ta3);
            }
        }

        
        
        
        
        
        private void da6(object sender, EventArgs e)
        {            
            
            if (da2.Rows.Count <= 0)
            {
                return;
            }
            
            Ta2();

            
            int ta4 = To();
            
            Fo7(ta4);
        }

        
        
        
        private void Co4()
        {
            try
            {
                
                He();
                
                Fo8();
                
                Da6();
                
                Co8();
            }
            catch
            {
                throw;
            }
        }

        
        
        
        private void He()
        {
            la7.Re2();
            da7.Value = DateTime.No2;
            if (co.Se2 != null) co.Se3 = CO.BL;
            if (co2.Se2 != null) co2.Se3 = CO.BL;
            te.Clear();
        }

        
        
        
        private void Fo8()
        {            
            la2.Te = string.Em;
            la4.Te = string.Em;
            la6.Te = string.Em;            
        }

        
        
        
        private void Da6()
        {
            
            da2.Rows.Clear();
            
            da2.Au = false;
            
            da2.Ro4 = false;
            
            da2.Se4 = Da7.Ce;
            
            da2.Mu = false;
            
            da2.Al = false;
            da2.Al2 = true;
            
            da2.Al3 = false;
            
            foreach (Da8 co3 in da2.Columns)
            {
                co3.Re3 = true;
            }
            da2.Columns[It.In2].Re3 = false;
            da2.Columns[Qu.In2].Re3 = false;
            
            da2.Columns[Un.In2].De2.Fo6 = "#,##0";
            da2.Columns[Qu.In2].De2.Fo6 = "#,##0";
            da2.Columns[Ta3.In2].De2.Fo6 = "#,##0";            
            
            da2.Ed2 = Da9.Ed3;
        }

        
        
        
        private void Co8()
        {
            try
            {
                
                co2.Dr2 = Co9.Dr3;
                co.Dr2 = Co9.Dr3;

                
                string cu = Qu2.Cr2();
                string ta5 = Qu2.Cr3();
                string co4 = Qu2.Cr4();

                
                op.Co10();
                DataTable dt3 = op.Ex(cu);
                DataTable dt4 = op.Ex(ta5);
                dt2 = op.Ex(co4);

                
                Ut.Co11(dt3, co2);
                Ut.Co12(dt4, co);
                Ut.Co13(dt2,
                    (Da10)da2.Columns[It.In2]);
            }
            catch
            {
                throw;
            }
            finally
            {
                op.Close();
            }
        }

        
        
        
        private void Ge2()
        {
            try
            {                
                
                string ta6 = Qu2.Cr5();

                
                op.Co10();
                dt5 = op.Ex(ta6);
            }
            catch
            {
                throw;
            }
            finally
            {
                op.Close();
            }
        }

        
        
        
        private void Pr2()
        {
            try
            {
                switch (mo)
                {
                    
                    
                    case MO.RE:
                        Ne3();
                        bu6.Te = BU.RE2;
                        break;

                    
                    
                    case MO.ED:
                        la7.Te = sa;
                        Sa3();
                        Sa4();
                        bu6.Te = BU.ED2;
                        break;

                    
                    
                    
                    case MO.DE:
                        la7.Te = sa;
                        Sa3();
                        Sa4();
                        Re4();                       
                        bu6.Te = BU.DE2;
                        break;
                }
            }
            catch
            {
                throw;
            }
        }
        
        
        
        
        private void Ne3()
        {
            try
            {
                
                
                string sq = Qu2.Cr6();

                
                op.Co10();
                DataTable dt5 = op.Ex(sq);
                DataRow ro = dt5.Rows[0];  
                
                
                
                la7.Te = (int.Parse(ro[DA.MA].ToString()) + 1).ToString();

                
                Ta2();
            }
            catch
            {
                throw;
            }
            finally
            {
                op.Close();
            }
        }

        
        
        
        private void Sa3()
        {
            try
            {
                
                
                string sq = Qu2.Cr7(sa);

                
                op.Co10();
                DataTable dt5 = op.Ex(sq);

                
                DataRow ro = dt5.Rows[0];
                
                da7.Value = (DateTime)ro[DA.SA];
                co.Se2 = ro[DA.TA];
                co2.Se2 = ro[DA.CU];
                te.Te = ro[DA.TI].ToString();
                te2.Te = ro[DA.ME].ToString();
                ta = int.Parse(ro[DA.TA2].ToString());
                la2.Te = ro[DA.TO].ToString();
                int ta4 = (int)ro[DA.TO];                
                
                
                Fo7(ta4);
            }
            catch
            {
                throw;
            }
            finally 
            {
                op.Close();
            }
        }

        
        
        
        
        private void Fo7(int ta4)
        { 
            
            la4.Te = Math.Tr
                        ((double)ta4 * ta / TA3.FO).ToString();

            
            int sa2 = int.Parse(la4.Te.Re5(LA.CO2, LA.EM));

            
            la6.Te = (ta4 + sa2).ToString();
        }

        
        
        
        private void Sa4()
        {
            try
            {
                
                string sq = Qu2.Cr8(sa);

                
                op.Co10();
                DataTable dt5 = op.Ex(sq);

                
                foreach (DataRow ro in dt5.Rows)
                {
                    
                    object[] ro2 = ro.It2;
                    
                    da2.Rows.Add(ro2);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                op.Close();
            }
        }

        
        
        
        private void Re4()
        {
            la7.En2 = false;
            te.Re3 = true;
            te2.Re3 = true;
            da2.Re3 = true;
            la2.En2 = false;
            la4.En2 = false;
            la6.En2 = false;

            
            da7.En2 = false;
            co.En2 = false;
            co2.En2 = false;
            te.En2 = false;
            bu7.En2 = false;
            bu8.En2 = false;
            da2.En2 = false;
        }

        
        
        
        private void Ro()
        {
            int ma =0;
            
            if (da2.Ro5 > 0)
            {
                
                List<int> li = new List<int>();

                foreach (Da11 ro in da2.Rows)
                {
                    li.Add(int.Parse(ro.Ce2[De3.In2].Value.ToString()));
                }
                ma = li.Ma();
            }

            
            da2.Rows.Add();

            
            
            da2[St2.In2, da2.Ro5 - 1].Value = ST.AD;

            
            da2[De3.In2, da2.Ro5 - 1].Value = ma + 1;
        }

        
        
        
        private void Ro2()
        {
            
            if (da2.Ro5 <= 0 || da2.Cu == null)
            {
                return;
            }            

            
            int st = 0;
            Da11 de = null;

            st = int.Parse(
                da2[St2.In2, da2.Cu.Ro3].Value.ToString());
            de = da2.Rows[da2.Cu.Ro3];

            
            switch (st)
            {
                
                case ST.AD:

                    da2.Rows.Remove(de);
                    break;

                
                case ST.EX:
                case ST.ED:

                    
                    int cu2 = da2.Cu.Co6;
                    int cu3 = da2.Cu.Ro3;

                    
                    da2[St2.In2, da2.Cu.Ro3].Value = ST.DE3;
                    de.Vi3 = false;

                    
                    Se5(cu2, cu3);

                    
                    int ta4 = To();

                    
                    Fo7(ta4);

                    break;
            }
        }

        
        
        
        
        
        private void Se5(int cu2,int cu3) 
        {
            
            int co5 = 0;
            foreach (Da11 ro in da2.Rows)
            {
                if (ro.Vi3)
                {
                    co5 += 1;
                }
            }

            
            if (co5 >= 1)
            {
                
                
                bool la8 = false;
                for (int i = 0; i < da2.Rows.Count - cu3; i++)
                {
                    if (da2[cu2, cu3 + i].Vi3)
                    {
                        la8 = true; 
                        break;
                    }
                }

                
                if (la8)
                {
                    
                    for (int i = 0; i < da2.Rows.Count; i++)
                    {
                        
                        if (da2[cu2, cu3 + i].Vi3)
                        {
                            da2[cu2, cu3 + i].Se6 = true;
                            break;
                        }
                    }
                }

                
                if (!la8)
                {
                    
                    
                    for (int i = 0; i < da2.Rows.Count; i++)
                    {
                        
                        if (da2[cu2, cu3 - i].Vi3)
                        {
                            da2[cu2, cu3 - i].Se6 = true;
                            break;
                        }
                    }
                }
            }
        }

        
        
        
        
        private void Am(object it)
        {
            try
            {
                
                if (it == null)
                {
                    
                    da2[Un2.In2, da2.Cu.Ro3].Value = null;
                    da2[Un.In2, da2.Cu.Ro3].Value = null;
                    da2[Ta3.In2, da2.Cu.Ro3].Value = 0;
                    To();
                }

                
                else
                {
                    
                    dt2.De4.Ro6 = 
                        $"[{CO.IT}] = '{it}'"; 
                    
                    
                    Da12 dr = dt2.De4[0];

                    
                    da2.Ce3 -= da3;

                    
                    da2[Un2.In2, da2.Cu.Ro3].Value =
                        dr[CO.UN].ToString();
                    da2[Un.In2, da2.Cu.Ro3].Value =
                        dr[CO.SA2].ToString();

                    
                    if (da2[Qu.In2, da2.Cu.Ro3].Value != null)
                    {
                        To2();
                    }
                    
                    else
                    {
                        
                        da2[Ta3.In2, da2.Cu.Ro3].Value =
                            0;
                    }

                    
                    da2.Ce3 += da3;
                }
            }
            catch
            {
                throw;
            }
            finally 
            {
                op.Close();
            }
        }

        
        
        
        private void Am2()
        {
            
            da2.Ce3 -= da3;            

            
            if (da2[Un.In2, da2.Cu.Ro3].Value != null)
            {
                To2();
            }
            
            else
            {
                
                da2[Ta3.In2, da2.Cu.Ro3].Value = 0;
            }

            
            da2.Ce3 += da3;
        }

        
        
        
        private void To2() 
        {
            int Un3;
            int Qu3;

            
            if (da2.Cu.Value == null) 
            {
                
                da2.Cu.Value = 0;
            }

            
            if (int.TryParse(
                da2[Un.In2, da2.Cu.Ro3].Value.ToString(),
                out Un3) &&
                int.TryParse(
                    da2[Qu.In2, da2.Cu.Ro3].Value.ToString(),
                    out Qu3))
            {
                
                da2[Ta3.In2, da2.Cu.Ro3].Value =
                    Un3 * Qu3;
            }

            
            int ta4 = To();

            
            Fo7(ta4);
        }

        
        
        
        
        private int To()
        {
            
            
            int su = 0;
            foreach (Da11 ro in da2.Rows)
            {
                
                if (ro.Vi3 && ro.Ce2[Ta3.In2].Value != null)
                {
                    su += int.Parse(ro.Ce2[Ta3.In2].Value.ToString());
                }
            }
            
            la2.Te = su.ToString();
            return su;
        }

        
        
        
        private void Re()
        {            
            
            string sa3 = Cr9();

            
            List<string>li = Cr10();

            
            try
            {
                op.Co10();
                op.Tr2();
                op.Ex2(sa3);
                foreach (string da8 in li ) 
                {
                    op.Ex2(da8);
                }                    
                op.Commit();
                Me2.Sh("登録2。");
                this.Close();
                
                Pr = true;
            }
            catch
            {
                op.Ro7();
                throw;
            }
            finally
            {
                op.Close();
            }
        }

        
        
        
        private string Cr9()
        {
            
            int su = 0;
            foreach (Da11 ro in da2.Rows)
            {
                
                su += int.Parse(ro.Ce2[Ta3.In2].Value.ToString());
            }

            
            string sa3 = Qu2.Cr11(
                la7.Te,
                co.Se2.ToString(),
                co2.Se2.ToString(),
                te.Te,
                su.ToString(),
                da7.Value.To3(),
                te2.Te);
            return sa3;
        }

        
        
        
        private List <string> Cr10() 
        {
            
            List<string> li = new List<string>();

            foreach (Da11 ro in da2.Rows)
            {
                
                string sa4 = Qu2.Cr10(
                    la7.Te,
                    ro.Ce2[De3.In2].Value.ToString(),
                    ro.Ce2[It.In2].Value.ToString(),
                    ro.Ce2[Qu.In2].Value.ToString(),
                    ro.Ce2[Ta3.In2].Value.ToString());

                li.Add(sa4);
            }
            return li;
        }

        
        
        
        private void Ed()
        {
            
            string sa5 = Cr12();

            
            List<string>li = Up();

            
            try
            {
                op.Co10();
                op.Tr2();
                op.Ex2(sa5);
                foreach (string da8 in li)
                {
                    op.Ex2(da8);
                }
                op.Commit();
                Me2.Sh("更新2。");
                this.Close();
                
                Pr = true;
            }
            catch
            {
                op.Ro7();
                throw;
            }
            finally
            {
                op.Close();
            }            
        }

        
        
        
        private string Cr12()
        {
            
            int su = 0;
            foreach (Da11 ro in da2.Rows)
            {
                
                su += int.Parse(ro.Ce2[Ta3.In2].Value.ToString());
            }

            
            string sa5 = Qu2.Cr13(
                sa,
                co.Se2.ToString(),
                co2.Se2.ToString(),
                te.Te,
                su.ToString(),
                da7.Value.To3(),
                te2.Te);
            return sa5;
        }

        
        
        
        private List<string> Up()
        {
            
            List<string>li = new List<string>();

            
            foreach (Da11 ro in da2.Rows)
            {
                
                string sa4 = null;
                string sa6 = null;
                string sa7 = null;

                
                switch (int.Parse(ro.Ce2[St2.In2].Value.ToString()))
                {
                    case ST.AD:
                        
                        sa4 = Qu2.Cr10(
                        la7.Te,
                        ro.Ce2[De3.In2].Value.ToString(),
                        ro.Ce2[It.In2].Value.ToString(),
                        ro.Ce2[Qu.In2].Value.ToString(),
                        ro.Ce2[Ta3.In2].Value.ToString());

                        li.Add(sa4);
                        break;

                    case ST.ED:
                        
                        sa6 = Qu2.Cr14(
                        la7.Te,
                        ro.Ce2[De3.In2].Value.ToString(),
                        ro.Ce2[It.In2].Value.ToString(),
                        ro.Ce2[Qu.In2].Value.ToString(),
                        ro.Ce2[Ta3.In2].Value.ToString(),
                        te2.Te);

                        li.Add(sa6);
                        break;

                    case ST.DE3:
                        
                        sa7 = Qu2.Cr15(
                        la7.Te,
                        ro.Ce2[De3.In2].Value.ToString());

                        li.Add(sa7);
                        break;
                }                
            }
            return li;
        }
                
        
        
        
        private void De()
        {
            
            List<string> li = new List<string>();

            
            string sa8 = Qu2.Cr16(la7.Te);
                
            
            string sa7 = Qu2.Cr17(
                la7.Te);                

            
            try
            {
                op.Co10();
                op.Tr2();
                op.Ex2(sa8);
                op.Ex2(sa7);
                op.Commit();
                Me2.Sh("削除2。");
                this.Close();
                
                Pr = true;
            }
            catch
            {
                op.Ro7();
                throw;
            }
            finally
            {
                op.Close();
            }            
        }        

        
        
        
        private bool Be()
        {
            
            if (da2.Rows.Count <= 0)
            {
                Me2.Sh("明細。");
                bu7.Fo9();
                return false;
            }
            
            if (co.Se3 == CO.BL)
            {
                Me2.Sh("担当。");
                co.Fo9();
                return false;
            }
            
            if (co2.Se3 == CO.BL)
            {
                Me2.Sh("顧客。");
                co2.Fo9();
                return false;
            }
            
            if (te.Te == "")
            {
                Me2.Sh("件名。");
                te.Fo9();
                return false;
            }

            foreach (Da11 ro in da2.Rows)
            {
                
                if (ro.Ce2[It.In2].Value == null)
                {
                    Me2.Sh("商品。");
                    ro.Ce2[It.In2].Se6 = true;
                    return false;
                }

                
                if (ro.Ce2[Qu.In2].Value == null || ro.Ce2[Qu.In2].Value.ToString() == "0")
                {
                    Me2.Sh("数量。");
                    ro.Ce2[Qu.In2].Se6 = true;
                    return false;
                }
            }     
            return true;
        }

        
        
        
        private void Ta2() 
        {
            
            DateTime sa9 = da7.Value;

            
            foreach (DataRow ro in dt5.Rows)
            {
                DateTime st2 = (DateTime)ro[DA.ST2];
                DateTime en = (DateTime)ro[DA.EN];

                
                if (sa9 >= st2 && sa9 <= en)
                {
                    
                    ta = (int)ro[DA.TA2];
                }
            }
        }
    }
}
