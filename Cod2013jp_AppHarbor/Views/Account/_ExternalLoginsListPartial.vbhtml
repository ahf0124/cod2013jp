﻿@ModelType ICollection(Of AuthenticationClientData)

@If Model.Count = 0 Then
    @<div class="message-info">
        <p>外部認証サービスが構成されていません。この ASP.NET アプリケーションをセットアップして、外部サービス経由でのログインをサポートする方法の詳細については、
<a href="http://go.microsoft.com/fwlink/?LinkId=252166">この記事</a>を参照してください。</p>
    </div>
Else
    Using Html.BeginForm("ExternalLogin", "Account", New With { .ReturnUrl = ViewData("ReturnUrl") })
    @Html.AntiForgeryToken()
    @<fieldset id="socialLoginList">
        <legend>別のサービスを使用してログイン</legend>
        <p>
        @For Each p as AuthenticationClientData in Model
            @<button type="submit" name="provider" value="@p.AuthenticationClient.ProviderName" title="@p.DisplayName アカウントを使用してログイン">@p.DisplayName</button>
        Next
        </p>
    </fieldset>
    End Using
End If
