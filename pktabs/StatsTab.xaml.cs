using System.Windows.Input;
using PKHeX.Core;
using static pk9reader.MainPage;

namespace pk9reader;

public partial class StatsTab : ContentPage
{
	public StatsTab()
	{
		InitializeComponent();
        ICommand refreshCommand = new Command(() =>
        {
            if (pk.Species != 0)
                applystatsinfo(pk);
            statrefresh.IsRefreshing = false;
        });
        statrefresh.Command = refreshCommand;
        applystatsinfo(pk);
    }

	public void applystatsinfo(PK9 pkm)
	{
        pkm.ResetPartyStats();
        statpic.Source = spriteurl;
        hpbasedisplay.Text = pkm.PersonalInfo.HP.ToString();
        HPIV.Text = pkm.IV_HP.ToString();
        HPEV.Text = pkm.EV_HP.ToString();
        totalhpdisplay.Text = pkm.Stat_HPCurrent.ToString();
        hpHyper.IsChecked = pk.IsHyperTrained(0);
        atkbasedisplay.Text = pkm.PersonalInfo.ATK.ToString();
        AtkIV.Text = pkm.IV_ATK.ToString();
        AtkEV.Text = pkm.EV_ATK.ToString();
        totalatkdisplay.Text = pkm.Stat_ATK.ToString();
        ATKHyper.IsChecked = pkm.IsHyperTrained(1);
        defbasedisplay.Text = pkm.PersonalInfo.DEF.ToString();
        DEFIV.Text = pkm.IV_DEF.ToString();
        DEFEV.Text = pkm.EV_DEF.ToString();
        totaldefdisplay.Text = pkm.Stat_DEF.ToString();
        DEFHyper.IsChecked = pkm.IsHyperTrained(2);
        spabasedisplay.Text = pkm.PersonalInfo.SPA.ToString();
        SPAIV.Text = pkm.IV_SPA.ToString();
        SPAEV.Text = pkm.EV_SPA.ToString();
        totalspadisplay.Text = pkm.Stat_SPA.ToString();
        SPAHyper.IsChecked = pkm.IsHyperTrained(3);
        spdbasedisplay.Text = pkm.PersonalInfo.SPD.ToString();
        SPDIV.Text = pkm.IV_SPD.ToString();
        SPDEV.Text = pkm.EV_SPD.ToString();
        totalspddisplay.Text = pkm.Stat_SPD.ToString();
        SPDHyper.IsChecked = pkm.IsHyperTrained(4);
        spebasedisplay.Text = pkm.PersonalInfo.SPE.ToString();
        SPEIV.Text = pkm.IV_SPE.ToString();
        SPEEV.Text = pkm.EV_SPE.ToString();
        totalspedisplay.Text = pkm.Stat_SPE.ToString();
        SPEHyper.IsChecked = pk.IsHyperTrained(5);
        totalbasedisplay.Text = pkm.PersonalInfo.GetBaseStatTotal().ToString();
        totalIVdisplay.Text = pkm.IVTotal.ToString();
        totalEVdisplay.Text = pkm.EVTotal.ToString();


    }

    private void applyhpIV(object sender, TextChangedEventArgs e)
    {
        if (HPIV.Text.Length > 0)
        {

            if (int.Parse(HPIV.Text) > 31)
                HPIV.Text = "31";
            pk.IV_HP = int.Parse(HPIV.Text);
            totalhpdisplay.Text = pk.Stat_HPCurrent.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applyhpEV(object sender, TextChangedEventArgs e)
    {
        if (HPEV.Text.Length > 0)
        {

            if (int.Parse(HPEV.Text) > 252)
                HPEV.Text = "252";
            pk.EV_HP = int.Parse(HPEV.Text);
            totalhpdisplay.Text = pk.Stat_HPCurrent.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applyatkIV(object sender, TextChangedEventArgs e)
    {
        if (AtkIV.Text.Length > 0)
        {
          
            if (int.Parse(AtkIV.Text) > 31)
                AtkIV.Text = "31";
            pk.IV_ATK = int.Parse(AtkIV.Text);
            totalatkdisplay.Text = pk.Stat_ATK.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }

    }

    private void applyatkEV(object sender, TextChangedEventArgs e)
    {
        if (AtkEV.Text.Length > 0)
        {

            if (int.Parse(AtkEV.Text) > 252)
                AtkEV.Text = "252";
            pk.EV_ATK = int.Parse(AtkEV.Text);
            totalatkdisplay.Text = pk.Stat_ATK.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applydefIV(object sender, TextChangedEventArgs e)
    {
        if (DEFIV.Text.Length > 0)
        {
            if (int.Parse(DEFIV.Text) > 31)
                DEFIV.Text = "31";
            pk.IV_DEF = int.Parse(DEFIV.Text);
            totaldefdisplay.Text = pk.Stat_DEF.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applydefEV(object sender, TextChangedEventArgs e)
    {
        if (DEFEV.Text.Length > 0)
        {
            if (int.Parse(DEFEV.Text) > 252)
                DEFEV.Text = "252";
            pk.EV_DEF = int.Parse(DEFEV.Text);
            totaldefdisplay.Text = pk.Stat_DEF.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applyspaIV(object sender, TextChangedEventArgs e)
    {
        if (SPAIV.Text.Length > 0)
        {
            if (int.Parse(SPAIV.Text) > 31)
                SPAIV.Text = "31";
            pk.IV_SPA = int.Parse(SPAIV.Text);
            totalspadisplay.Text = pk.Stat_SPA.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applyspaEV(object sender, TextChangedEventArgs e)
    {
        if (SPAEV.Text.Length > 0)
        {

            if (int.Parse(SPAEV.Text) > 252)
                SPAEV.Text = "252";
            pk.EV_SPA = int.Parse(SPAEV.Text);
            totalspadisplay.Text = pk.Stat_SPA.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applyspdIV(object sender, TextChangedEventArgs e)
    {
        if (SPDIV.Text.Length > 0)
        {
            if (int.Parse(SPDIV.Text) > 31)
                SPDIV.Text = "31";
            pk.IV_SPD = int.Parse(SPDIV.Text);
            totalspddisplay.Text = pk.Stat_SPD.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applyspdEV(object sender, TextChangedEventArgs e)
    {
        if (SPDEV.Text.Length > 0)
        {
            if (int.Parse(SPDEV.Text) > 252)
                SPDEV.Text = "252";
            pk.EV_SPD = int.Parse(SPDEV.Text);
            totalspddisplay.Text = pk.Stat_SPD.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void applyspeIV(object sender, TextChangedEventArgs e)
    {
        if (SPEIV.Text.Length > 0)
        {
            if (int.Parse(SPEIV.Text) > 31)
                SPEIV.Text = "31";
            pk.IV_SPE = int.Parse(SPEIV.Text);
            totalspedisplay.Text = pk.Stat_SPE.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }

    }

    private void applyspeEV(object sender, TextChangedEventArgs e)
    {
        if (SPEEV.Text.Length > 0)
        {
            
            if (int.Parse(SPEEV.Text) > 252)
                SPEEV.Text = "252";
            pk.EV_SPE = int.Parse(SPEEV.Text);
            totalspedisplay.Text = pk.Stat_SPE.ToString();
            totalIVdisplay.Text = pk.IVTotal.ToString();
            totalEVdisplay.Text = pk.EVTotal.ToString();
        }
    }

    private void randomizeivs(object sender, EventArgs e)
    {
        
        pk.SetRandomIVs();
    }

    private void perfectivs(object sender, EventArgs e)
    {
        Span<int> ivs = stackalloc int[6];
        ivs.Fill(pk.MaxIV);
        pk.IVs = ivs.ToArray();
    }

    private void randomizeevs(object sender, EventArgs e)
    {
        Span<int> ivs = stackalloc int[6];
       
        EffortValues.SetRandom(ivs, 9);
        pk.SetEVs(ivs);
    }

    private void suggestedevs(object sender, EventArgs e)
    {
        Span<int> ivs = stackalloc int[6];
        
        EffortValues.SetMax(ivs,pk);
        pk.SetEVs(ivs);
    }

    private void applyHPhyper(object sender, CheckedChangedEventArgs e)
    {
        pk.HyperTrainInvert(0);
    }
    private void applyATKhyper(object sender, CheckedChangedEventArgs e)
    {
        pk.HyperTrainInvert(1);
    }
    private void applyDEFhyper(object sender, CheckedChangedEventArgs e)
    {
        pk.HyperTrainInvert(2);
    }
    private void applySPAhyper(object sender, CheckedChangedEventArgs e)
    {
        pk.HyperTrainInvert(3);
    }
    private void applySPDhyper(object sender, CheckedChangedEventArgs e)
    {
        pk.HyperTrainInvert(4);
    }
    private void applySPEhyper(object sender, CheckedChangedEventArgs e)
    {
        pk.HyperTrainInvert(5);
    }
}