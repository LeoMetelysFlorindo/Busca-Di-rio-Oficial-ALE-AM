'Aplicativo de Busca de Diários Oficiais
'Data Criação: 06/08/2015 11:22h
'Objetivo: Fornecer aos servidores da Casa Legislativa um mecanismo de busca rápido de textos
'          contidos nos diários oficiais eletrônicos já criados
'Desenvolvedor: Leonardo Metelys
'Gerência de Aplicativos - Diretoria de Informática 


Imports System.Drawing
Imports System.Runtime
Imports System.IO


Public Class _Default
    Inherits Page

    'Texto a ser procurado
    Public Stexto = ""

    'Endereço de busca dos PDF´s na rede
    Public sEndereco As String = "\\172.16.0.31\dol"


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        TxtPesq.Focus()

        Chk2018.Checked = True

    End Sub

    
    Public Function PesquisanoPDF(PdfFileName As String) As String


        Dim sArquivo As String = ""

        'Para tornar a consulta mais rápida, seperam-se os pdf em pastas de anos

        'Pesquisar diários de 2011
        If Chk2011.Checked = True Then

            sArquivo = "\\172.16.0.31\DOL\2011\" + PdfFileName

        End If

        'Pesquisar diários de 2012
        If Chk2012.Checked = True Then

            sArquivo = "\\172.16.0.31\DOL\2012\" + PdfFileName

        End If

        'Pesquisar diários de 2013
        If Chk2013.Checked = True Then

            sArquivo = "\\172.16.0.31\DOL\2013\" + PdfFileName

        End If

        'Pesquisar diários de 2014
        If Chk2014.Checked = True Then

            sArquivo = "\\172.16.0.31\DOL\2014\" + PdfFileName

        End If

        'Pesquisar diários de 2015
        If Chk2015.Checked = True Then

            sArquivo = "\\172.16.0.31\DOL\2015\" + PdfFileName

        End If

        'Pesquisar diários de 2016
        If Chk2016.Checked = True Then

            sArquivo = "\\172.16.0.31\DOL\2016\" + PdfFileName

        End If

        'Pesquisar diários de 2017
        If Chk2017.Checked = True Then

            sArquivo = "\\172.16.0.31\DOL\2017\" + PdfFileName

        End If

        'Pesquisar diários de 2017
        If Chk2018.Checked = True Then

            sArquivo = "\\172.16.0.31\DOL\2018\" + PdfFileName

        End If

        'Abrir o Arquivo PDF
        Dim oReader As New iTextSharp.text.pdf.PdfReader(sArquivo)

        Dim sOut = ""

        'Procurar dentro do arquivo PDF pelo texto informado
        For i = 1 To oReader.NumberOfPages
            Dim its As New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy

            sOut &= iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(oReader, i, its)
        Next

        Return sOut



    End Function

    Protected Sub TxtPesq_TextChanged(sender As Object, e As EventArgs) Handles TxtPesq.TextChanged

        TxtResposta.Text = ""

        Chk2011.Enabled = True
        Chk2012.Enabled = True
        Chk2013.Enabled = True
        Chk2014.Enabled = True
        Chk2015.Enabled = True
        Chk2016.Enabled = True
        Chk2017.Enabled = True


    End Sub

    Protected Sub Chk2011_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2011.CheckedChanged

        If Chk2011.Checked = True Then

            Chk2012.Checked = False
            Chk2013.Checked = False
            Chk2014.Checked = False
            Chk2015.Checked = False
            Chk2016.Checked = False
            Chk2017.Checked = False
            Chk2018.Checked = False

        End If

    End Sub

    Protected Sub Chk2012_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2012.CheckedChanged
        If Chk2012.Checked = True Then

            Chk2011.Checked = False
            Chk2013.Checked = False
            Chk2014.Checked = False
            Chk2015.Checked = False
            Chk2016.Checked = False
            Chk2017.Checked = False
            Chk2018.Checked = False

        End If


    End Sub

    Protected Sub Chk2013_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2013.CheckedChanged

        If Chk2013.Checked = True Then

            Chk2011.Checked = False
            Chk2012.Checked = False
            Chk2014.Checked = False
            Chk2015.Checked = False
            Chk2016.Checked = False
            Chk2017.Checked = False
            Chk2018.Checked = False
        End If

    End Sub

    Protected Sub Chk2014_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2014.CheckedChanged


        If Chk2014.Checked = True Then

            Chk2011.Checked = False
            Chk2012.Checked = False
            Chk2013.Checked = False
            Chk2015.Checked = False
            Chk2016.Checked = False
            Chk2017.Checked = False
            Chk2018.Checked = False
        End If


    End Sub

    Protected Sub Chk2015_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2015.CheckedChanged

        If Chk2015.Checked = True Then

            Chk2011.Checked = False
            Chk2012.Checked = False
            Chk2013.Checked = False
            Chk2014.Checked = False
            Chk2016.Checked = False
            Chk2017.Checked = False
            Chk2018.Checked = False
        End If


    End Sub

    Protected Sub Chk2016_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2016.CheckedChanged

        If Chk2016.Checked = True Then

            Chk2011.Checked = False
            Chk2012.Checked = False
            Chk2013.Checked = False
            Chk2014.Checked = False
            Chk2015.Checked = False
            Chk2017.Checked = False
            Chk2018.Checked = False
        End If


    End Sub

    Protected Sub bntPesquisar_Click(sender As Object, e As ImageClickEventArgs) Handles bntPesquisar.Click

        If TxtPesq.Text <> "" Then


            'Pesquisar somente os arquivos PDF e pôr em ordem na pasta informada
            Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(sEndereco)
            Dim oFileInfoCollection() As FileInfo
            Dim oFileInfo As FileInfo
            Dim i As Integer

            TxtResposta.Text = ""

            'Pesquisar diários de 2011
            If Chk2011.Checked = True Then

                Chk2012.Checked = False
                Chk2013.Checked = False
                Chk2014.Checked = False
                Chk2015.Checked = False
                Chk2016.Checked = False
                Chk2017.Checked = False
                Chk2018.Checked = False

                DirDiretorio = New DirectoryInfo("\\172.16.0.31\DOL\2011\")

            End If

            'Pesquisar diários de 2012
            If Chk2012.Checked = True Then

                Chk2011.Checked = False
                Chk2013.Checked = False
                Chk2014.Checked = False
                Chk2015.Checked = False
                Chk2016.Checked = False
                Chk2017.Checked = False
                Chk2018.Checked = False

                DirDiretorio = New DirectoryInfo("\\172.16.0.31\DOL\2012\")

            End If

            'Pesquisar diários de 2013
            If Chk2013.Checked = True Then

                Chk2012.Checked = False
                Chk2011.Checked = False
                Chk2014.Checked = False
                Chk2015.Checked = False
                Chk2016.Checked = False
                Chk2017.Checked = False
                Chk2018.Checked = False

                DirDiretorio = New DirectoryInfo("\\172.16.0.31\DOL\2013\")

            End If

            'Pesquisar diários de 2014
            If Chk2014.Checked = True Then

                Chk2012.Checked = False
                Chk2011.Checked = False
                Chk2013.Checked = False
                Chk2015.Checked = False
                Chk2016.Checked = False
                Chk2017.Checked = False
                Chk2018.Checked = False

                DirDiretorio = New DirectoryInfo("\\172.16.0.31\DOL\2014\")

            End If

            'Pesquisar diários de 2015
            If Chk2015.Checked = True Then


                Chk2011.Checked = False
                Chk2012.Checked = False
                Chk2013.Checked = False
                Chk2014.Checked = False
                Chk2016.Checked = False
                Chk2017.Checked = False
                Chk2018.Checked = False

                DirDiretorio = New DirectoryInfo("\\172.16.0.31\DOL\2015\")

            End If

            'Pesquisar diários de 2016
            If Chk2016.Checked = True Then

                Chk2012.Checked = False
                Chk2011.Checked = False
                Chk2013.Checked = False
                Chk2014.Checked = False
                Chk2015.Checked = False
                Chk2017.Checked = False
                Chk2018.Checked = False

                DirDiretorio = New DirectoryInfo("\\172.16.0.31\DOL\2016\")

            End If

            'Pesquisar diários de 2017
            If Chk2017.Checked = True Then

                Chk2012.Checked = False
                Chk2011.Checked = False
                Chk2013.Checked = False
                Chk2014.Checked = False
                Chk2015.Checked = False
                Chk2016.Checked = False
                Chk2018.Checked = False

                DirDiretorio = New DirectoryInfo("\\172.16.0.31\DOL\2017\")

            End If

            'Pesquisar diários de 2018
            If Chk2018.Checked = True Then

                Chk2012.Checked = False
                Chk2011.Checked = False
                Chk2013.Checked = False
                Chk2014.Checked = False
                Chk2015.Checked = False
                Chk2016.Checked = False
                Chk2017.Checked = False

                DirDiretorio = New DirectoryInfo("\\172.16.0.31\DOL\2018\")

            End If

            'Selecinar os arquivos PDF´s da pasta indicada
            oFileInfoCollection = DirDiretorio.GetFiles("*.pdf")
            '### Lista somente os PDFps


            'Texto encontrado
            Stexto = ""

            'Para cada arquivo PDF contido na pasta indicada...
            For i = 0 To oFileInfoCollection.Length() - 1

                'Selecionar um arquivo
                oFileInfo = oFileInfoCollection.GetValue(i)


                'Abrir cada arquivo PDF e extrair o texto do mesmo
                Stexto = PesquisanoPDF(oFileInfo.Name)

                'Pesquisar a Palavra
                Dim index As Integer = Stexto.IndexOf(TxtPesq.Text)

                'Se encontrou a palavra pesquisada dentro do arquivo PDF aberto
                If index >= 0 Then

                    'Pesquisar o LOCAL EXATO onde encontrou a palavra dentro do arquivo PDF
                    Try

                        Dim index_2 As Integer = Stexto.IndexOf(".", index + 25)
                        Dim getTexto As String = Stexto.Substring(index, Stexto.IndexOf(".", index + 75) - (index - 5))

                        'Mostrar na caixa de Texto ao usuário o Nome do arquivo PDF encontrado e uma amostra do texto que bate com o que ele forneceu na pesquisa
                        TxtResposta.Text = TxtResposta.Text + "Texto presente no arquivo: " + oFileInfo.Name + ". Extrato do texto: " + getTexto + "." + vbCrLf

                    Catch ex As Exception

                        'Data: 14/03/2018 13:25h Ajuste fino para 2016
                        Dim sJuste As Integer = index - 6581
                        Dim sAjuste2 As Integer = index - 3081
                        Dim index_2 As Integer = Stexto.IndexOf(".", index - 75)
                        Dim getTexto As String = Stexto.Substring(sJuste, Stexto.IndexOf(":", sAjuste2))
                        'Mostrar na caixa de Texto ao usuário o Nome do arquivo PDF encontrado e uma amostra do texto que bate com o que ele forneceu na pesquisa
                        TxtResposta.Text = TxtResposta.Text + "Texto presente no arquivo: " + oFileInfo.Name + ". Extrato do texto: " + getTexto + "." + vbCrLf

                    End Try





                End If

            Next

            TxtResposta.Enabled = True


            TxtResposta.Focus()

        Else

            TxtResposta.Text = "TEXTO DE PESQUISA EM BRANCO! DIGITE UM TEXTO!!"

        End If

    End Sub

    Protected Sub Chk2017_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2017.CheckedChanged

        If Chk2017.Checked = True Then

            Chk2011.Checked = False
            Chk2012.Checked = False
            Chk2013.Checked = False
            Chk2014.Checked = False
            Chk2015.Checked = False
            Chk2016.Checked = False
            Chk2018.Checked = False

        End If

    End Sub
    '03/0/2018 08:41h
    'Criando pesquisa de PDF´s de 2018
    'Desenvolvedor: Leonardo Metelys
    Protected Sub Chk2018_CheckedChanged(sender As Object, e As EventArgs) Handles Chk2018.CheckedChanged

        If Chk2018.Checked = True Then

            Chk2011.Checked = False
            Chk2012.Checked = False
            Chk2013.Checked = False
            Chk2014.Checked = False
            Chk2015.Checked = False
            Chk2016.Checked = False
            Chk2017.Checked = False

        End If


    End Sub
End Class