Public Class FRMChevyCar

    '******************************'
    Public Price As Single
    Dim Options As Single = 975
    Dim Trade As Single
    Dim Air As Single
    Dim Subtot As Single
    Dim GST As Single
    Dim PST As Single
    Dim Tot As Single
    Dim Pay As Single
    Dim Sum As Single
    Dim Rate As Single
    Dim Month As Single
    '******************************'

    Public Sub Docalc()

        Subtot = Price + Options - Trade + Air

        GST = Subtot * 0.08
        PST = Subtot * 0.07

        Tot = Subtot + GST + PST

        LBLBase.Text = FormatCurrency(Price)
        LBLSub.Text = FormatCurrency(Subtot)
        LBLOptions.Text = FormatCurrency(Options)
        LBLAir.Text = FormatCurrency(Air)
        LBLGST.Text = FormatCurrency(GST)
        LBLPST.Text = FormatCurrency(PST)
        LBLTotal.Text = FormatCurrency(Tot)
        LBLOptions.Text = FormatCurrency(Options)


    End Sub

    Public Sub Aveo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Docalc()

    End Sub

    Private Sub GBXOptions_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBXOptions.Enter

    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RADSun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RADAir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GBXFin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBXFin.Enter

    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HSRate.Scroll

        LBLRate.Text = HSRate.Value / 10

    End Sub

    Private Sub CHKPDI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKPDI.CheckedChanged

        CHKPDI.Enabled = False

    End Sub

    Private Sub CHKPlay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKPlay.CheckedChanged

        CHKPlay.Enabled = False

    End Sub

    Private Sub CHKAir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKAir.CheckedChanged

        If CHKAir.Checked = True Then

            Air = 100
            Options += 1150

        Else

            Air = 0
            Options -= 1150

        End If

        LBLAir.Text = FormatCurrency(Air)

        Docalc()

    End Sub

    Private Sub LineShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineShape1.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOMonths.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub LBLTrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLTrade.Click



    End Sub

    Private Sub TXTTrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTrade.TextChanged

        Trade = Val(TXTTrade.Text)
        LBLTrade.Text = FormatCurrency(Trade)

    End Sub

    Private Sub LBLOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLOptions.Click


    End Sub

    Private Sub LBLAir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLAir.Click



    End Sub

    Private Sub LBLSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLSub.Click



    End Sub

    Private Sub LBLGST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLGST.Click

    End Sub

    Private Sub LBLOptions_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBLOptions.TextChanged

        Docalc()

    End Sub

    Private Sub LBLTrade_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBLTrade.TextChanged

        Docalc()

    End Sub

    Private Sub LBLAir_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBLAir.TextChanged

        Docalc()

    End Sub

    Private Sub BTNClacFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNClacFin.Click


        If LBLRate.Text = Nothing Then

            FixError()
            Clear()

        ElseIf CBOMonths.Text = Nothing Then

            FixError()
            Clear()

        Else

            Rate = LBLRate.Text
            Month = CBOMonths.Text

            Pay = Pmt(Rate / 100 / 12, Month, -1 * Tot, 0, 1)

            LBLMonPay.Text = FormatCurrency(Pay)

            Sum = Pay * (Month)

            LBLSumPay.Text = FormatCurrency(Sum)

        End If
    End Sub

    Private Sub BTNClearFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNClearFin.Click

        Clear()

    End Sub
    Public Sub Clear()

        HSRate.Value = Nothing
        CBOMonths.Text = Nothing
        LBLRate.Text = Nothing
        LBLMonPay.Text = Nothing
        LBLSumPay.Text = Nothing


    End Sub

    Private Sub BTNPick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNPick.Click

        Me.Close()

    End Sub

    Private Sub BTNExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNExit.Click

        Me.Close()
        FRMChevyPick.Close()
        FRMMenu.Close()

    End Sub

    Private Sub RADAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RADAuto.CheckedChanged

        If RADAuto.Checked = True Then

            Options += 1150

        Else

            Options -= 1150

        End If

        Docalc()

    End Sub

    Private Sub CHKSun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKSun.CheckedChanged

        If CHKSun.Checked = True Then

            Options += 985

        Else

            Options -= 985

        End If

        Docalc()

    End Sub

    Private Sub CHKUSB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKUSB.CheckedChanged

        If CHKUSB.Checked = True Then

            Options += 105

        Else

            Options -= 105

        End If

        Docalc()

    End Sub

    Private Sub CHKOil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKOil.CheckedChanged

        If CHKOil.Checked = True Then

            Options += 100

        Else

            Options -= 100

        End If

        Docalc()

    End Sub

    Private Sub CHKSpoiler_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKSpoiler.CheckedChanged

        If CHKSpoiler.Checked = True Then

            Options += 295

        Else

            Options -= 295

        End If

        Docalc()

    End Sub

    Private Sub CHKSeats_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKSeats.CheckedChanged

        If CHKSeats.Checked = True Then

            Options += 250

        Else

            Options -= 250

        End If

        Docalc()

    End Sub

    Private Sub BTNReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNReset.Click

        RADMan.Checked = True
        CHKAir.Checked = False
        CHKSun.Checked = False
        CHKUSB.Checked = False
        CHKOil.Checked = False
        CHKSpoiler.Checked = False
        CHKSeats.Checked = False

    End Sub

    Public Sub FixError()

        MsgBox("Make Sure to select both the Rate and the Months of the loan before continuing.")

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLDummy.Click

    End Sub

    Private Sub Label12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBLDummy.TextChanged

        Price = LBLDummy.Text

    End Sub

    Shared Function LBLDummy1() As Object
        Throw New NotImplementedException
    End Function

    Private Sub LBLBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLBase.Click

    End Sub
End Class