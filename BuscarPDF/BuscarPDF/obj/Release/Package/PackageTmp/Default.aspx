<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="BuscarPDF._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1> 
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/brasaomini.png" />
&nbsp;PESQUISA DE TEXTOS NO DIÁRIO OFICIAL DA ALEAM. v6.2018</h1>
                <h4 <span style="color:#27408B;margin-left:10px;">Selecione UM ANO. Informe o texto. A lista de diários oficiais que contêm a frase de pesquisa será preenchida abaixo. A pesquisa pode consumir certo tempo... </span></h4> 
                <h4 <span style="color:#27408B;margin-left:10px;">Os diários Oficiais tem como nomeclatura a Edição e a data. Exemplo: Edicao04810102011.pdf (Edição 048, de 10/10/2011). Após fazer sua pesquisa para ter acesso ao PDF vá até o Portal ALEAM (www.ale.am.gov.br) e, no menu           
                TRANSPARÊNCIA, selecione a opção DIÁRIO OFICIAL. Informe o ANO e o MÊS e clique em consultar para ter acesso a Edição desejada.</span></h4>
            </hgroup>
          
        </div>
    </section>
    <br/>
</asp:Content>


 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
     <br/> 
      <br/>
    <br/>
    <br/>
    <br/>
    <br/> 
    <div style="text-align:left; margin-left:11px; ">

    <style type="text/css">
    label { display: inline-block; }
    </style>      
    <asp:CheckBox ID="Chk2011"  Text="2011" runat="server" AutoPostBack="True" />
    <asp:CheckBox ID="Chk2012" style="text-align:left; margin-left:20px;" Text="2012" runat="server" AutoPostBack="True" />
    <asp:CheckBox ID="Chk2013" style="text-align:left; margin-left:20px;"  Text="2013" runat="server" AutoPostBack="True" />
    <asp:CheckBox ID="Chk2014" style="text-align:left; margin-left:20px;"  Text="2014" runat="server" AutoPostBack="True" />
    <asp:CheckBox ID="Chk2015" style="text-align:left; margin-left:20px;"  Text="2015" runat="server" AutoPostBack="True" />
    <asp:CheckBox ID="Chk2016" style="text-align:left; margin-left:20px;"  Text="2016" runat="server" AutoPostBack="True" />
    <asp:CheckBox ID="Chk2017" style="text-align:left; margin-left:20px;"  Text="2017" runat="server" AutoPostBack="True" />
    <asp:CheckBox ID="Chk2018" style="text-align:left; margin-left:20px;"  Text="2018" runat="server" AutoPostBack="True" />
    
   </div>      
     <br />      
   <div style="text-align:left; margin-left:15px; ">
    <asp:Label ID="Label1" runat="server" Text="Defina o texto a pesquisar: "></asp:Label>
   </div>  
  
   <div class="blocoGrupoCampos">
   <div style="text-align:left; margin-left:15px; height: 35px;">
   <asp:TextBox ID="TxtPesq" runat="server" Width="429px" Height="27px"></asp:TextBox>
             <asp:ImageButton ID="bntPesquisar" runat="server" 
                        ImageUrl="~/Images/pesq.jpg" 
                        Style="background-image: url(~/Styles/Imagens/pesqback.jpg);
                            background-repeat: no-repeat; margin-top:15px;  background-position: right;" 
                            ForeColor="Black"  Height="22px" Width="104px" />                  
                </div>
       </div>
    </br>
    </br>
 
    <asp:TextBox ID="TxtResposta" runat="server" style="margin-left:15px;" Height="123px" TextMode="MultiLine" Width="1000px" Enabled="False"></asp:TextBox>

    <h3> Instruções de uso:</h3>
    <ol class="round">
        <li class="one">
            <h5>Iniciando</h5>
            Selecione um ano para que a pesquisa possa ter mais rapidez na busca.
        </li>
        <li class="two">
            <h5>Fazer pesquisa</h5>
            Informe uma palavra concernente ao que procura. Por exemplo: AMAZONPREV ou o nome da pessoa em letras maiúsculas. Clique em Pesquisar.             
        </li>
        <li class="three">     
            <h5>Nova pesquisa</h5>       
            Para realizar uma nova busca simplesmente clique no campo texto em "Defina o texto a pesquisar". Os anos serão novamente habilitados para escolha e nova consulta.  
        </li>
        <li class="three">     
            <h5>Lista de Diários Oficiais</h5>       
            Cada novo Diário Oficial é acrescentado no dia seguinte à sua publicação. A lista de diários oficiais presente em nosso banco de dados é sempre revisada.   
        </li>
    </ol> 

    <div class="content-wrapper">
            <div STYLE="font-family: Humnst777 Cn BT; font-size: 12px; color: blue" class="float-left">
                <p>
                  <b><%:DateTime.Now.Year%> - Assembléia Legislativa do Estado do Amazonas. Diretoria de Informática. Gerência de Aplicativos. Tel.: 3183-4340. Desenvolvedor: Leonardo Metelys.</b>
                </p>
            </div>
        </div>
</div>  
       
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
   
    
    
</asp:Content>

